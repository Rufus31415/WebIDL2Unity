using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WebIDL2Unity
{
    class InterfaceIDLType : JSONIDLType
    {
        public readonly bool IsWebIDLPartial;

        public readonly bool IsDictionnary;

        public readonly string Inheritance;

        public InterfaceIDLType(JObject jproperty, string module, bool isDictionnary) : base(jproperty, module)
        {
            IsWebIDLPartial = (bool)_jProperty["partial"];
            IsDictionnary = isDictionnary;

            Inheritance = _jProperty.Value<string>("inheritance");

        }

        private class Property
        {
            public string Type;
            public string Name;
        }

        private static IDLType GetTypeFromJSon(JToken member, GenerationContext context)
        {
            IDLType idlType;

            var genericType = member["idlType"].Value<string>("generic");

            if (!string.IsNullOrEmpty(genericType))
            {
                var genericTypeName = member["idlType"]["idlType"][0].Value<string>("idlType");


                if (!context.IDLObjects.TryGetValue(genericTypeName, out IDLType elementType))
                {
                    Console.WriteLine("Unknown IDL type for generic type : " + genericTypeName);
                    return null;
                }

                if (genericType == "FrozenArray") idlType = new SequenceIDLType(elementType, false, context);
                else if (genericType == "sequence") idlType = new SequenceIDLType(elementType, true, context);
                else if (genericType == "Promise") idlType = new PromiseIDLType(member, context);
                else
                {
                    Console.WriteLine("Unknown Generic IDL type : " + genericType);
                    return null;
                }
            }
            else
            {
                var typeName = member["idlType"].Value<string>("idlType");

                if (!context.IDLObjects.TryGetValue(typeName, out idlType))
                {
                    Console.WriteLine("Unknown IDL type : " + typeName);
                    return null;
                }
            }

            if (idlType is SequenceIDLType)
            {
                var sequenceIdlType = (SequenceIDLType)idlType;

                var existentSequenceType = context.IDLObjects.OfType<PrimitiveArrayIDLType>().FirstOrDefault(x => x.ElementType.Name == sequenceIdlType.ElementType.Name);

                if (existentSequenceType != null) idlType = existentSequenceType;
            }

            return idlType;
        }

        public override void Generate(GenerationContext context)
        {
            var partialDefinitions = context.IDLObjects.Where(x => string.Equals(x.Name, Name)).ToArray();

            var isNetPartialClass = partialDefinitions.Length > 1;

            var inheritance = partialDefinitions.OfType<InterfaceIDLType>().FirstOrDefault(x => !string.IsNullOrEmpty(x.Inheritance))?.Inheritance;

            var writableProperties = new List<Property>();

            using (StreamWriter csFile = GetFile(context.OutputDirectory, "cs"))
            {

                var jsLibElements = new List<string>();


                csFile.Write($@"
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public {(isNetPartialClass ? "partial " : "")} class {Name} : {(string.IsNullOrEmpty(inheritance) ? "WebIDL2UnityObject" : inheritance)}{string.Join("", context.IDLObjects.OfType<TypedefIDLType>().Where(x => x.Types.Contains(Name)).Select(x => $", {x.Name}").ToArray())} {{
");

                if (!IsWebIDLPartial)
                {
                    csFile.Write($@"

    internal {Name} (int id) : base(id) {{}}
");

                    if (IsDictionnary)
                    {
                        csFile.WriteLine($@"
    public {Name}() : base(WebIDL2UnityGetNewDictionnary()) {{ }}");

                    }
                }
                /*
                                    jslibFile.Write(@"
                mergeInto(LibraryManager.library, {
                ");
                */
                foreach (var member in _jProperty["members"])
                {
                    csFile.WriteLine();

                    var type = member.Value<string>("type");

                    switch (type)
                    {
                        case "attribute":
                        case "field":

                            var idlType = GetTypeFromJSon(member, context);

                            if (null == idlType) continue;

                            var attributeName = member.Value<string>("name");
                            var readOnly = !IsDictionnary && member.Value<bool>("readonly");


                            var nullable = member["idlType"].Value<bool>("nullable");

                            var netType = idlType.GetNETType(nullable);
                            var marshalType = idlType.GetMarshalType();
                            var propertyName = Helper.JavascriptToNETName(attributeName);




                            csFile.Write($@"
    public {netType} {propertyName} {{
        get {{
            var value = {idlType.GetterName()}(this.ID, ""{attributeName}"");
            return {idlType.MarshalToNET("value")};
        }}");

                            if (!readOnly)
                            {
                                writableProperties.Add(new Property() { Name = propertyName, Type = netType });

                                csFile.Write($@"
        set {{
            {idlType.SetterName()}(this.ID, ""{attributeName}"", {idlType.NETToMarshal("value")});
        }}");
                            }

                            csFile.WriteLine(@"
    }
");

                            break;

                        case "operation":
                        case "constructor":

                            var isConstructor = type == "constructor";
                            IDLType returnType = null;

                            if (!isConstructor)
                            {

                                returnType = GetTypeFromJSon(member, context);

                                if (returnType == null) continue;
                            }

                            if (member.Value<string>("special") == "getter")
                            {
                                if (member["arguments"].Count() != 1)
                                {
                                    Console.WriteLine("Only one argument is supported in getter");
                                    continue;
                                }

                                var typeName = member["arguments"][0]["idlType"].Value<string>("idlType");

                                IDLType indexType;

                                if (!context.IDLObjects.TryGetValue(typeName, out indexType))
                                {
                                    Console.WriteLine("Unknown IDL type for getter : " + typeName);
                                    continue;
                                }



                                csFile.Write($@"
    public {returnType.GetNETType(false)} this[{indexType.GetNETType(false)} index]
    {{
        get
        {{
            var value = {returnType.GetterName()}(this.ID, index.ToString());
            return {returnType.MarshalToNET("value")};
        }}
    }}
");
                            }
                            else
                            {
                                var nativeName = member.Value<string>("name");


                                var arguments = new Dictionary<string, IDLType>();

                                foreach (var argument in member["arguments"])
                                {
                                    if (argument.Value<string>("type") != "argument") continue;


                                    var argumentType = GetTypeFromJSon(argument, context);

                                    if (argumentType == null) continue;
                                    var argumentName = argument.Value<string>("name");

                                    arguments[argumentName] = argumentType;
                                }

                                // TODO : add optional arguments

                                var shouldReturnValue = isConstructor || !(returnType is UndefinedIDLType);

                                var netArguments = string.Join(", ", arguments.Select(x => $"{x.Value.GetNETType(false)} {x.Key}").ToArray());

                                if (isConstructor)
                                {
                                    var fullName = $"{Name}_{arguments.Count}";


                                    var argumentList = string.Join(", ", arguments.Select(x => x.Value.NETToMarshal(x.Key)).ToArray());

                                    csFile.Write($@"
    [DllImport(""__Internal"")]
    private static extern int {fullName}({string.Join(", ", arguments.Select(x => $"{x.Value.GetMarshalType()} {x.Key}").ToArray())});

    public {Name}({netArguments}) : base({fullName}({argumentList})) {{ }}
");

                                    jsLibElements.Add($@"
    {fullName} : function({string.Join(", ", arguments.Select(x => x.Key).ToArray())}) {{
        return _WebIDL2Unity.addReference(new {Name}({string.Join(", ", arguments.Select(x => x.Value.MarshalToJS(x.Key)).ToArray())}));
    }}
");

                                }
                                else
                                {
                                    var methodName = Helper.JavascriptToNETName(nativeName);

                                    var fullName = $"{Name}_{methodName}";

                                    var argumentList = string.Join("", arguments.Select(x => $", {x.Value.NETToMarshal(x.Key)}").ToArray());

                                   var isPromise = returnType is PromiseIDLType;

                                    if (isPromise)
                                    {
                                        var promise = (PromiseIDLType)returnType;

                                        var nativeArguments = $"int promise{string.Join("", promise.Args.Select(x => $", {x.Value.GetMarshalType()} {x.Key}").ToArray())}";
                                        csFile.Write($@"

    private static readonly Dictionary<int, Promise<{fullName}_delegate >> {fullName}_promises = new Dictionary<int, Promise<{fullName}_delegate>>();

    public delegate void {fullName}_delegate({string.Join(", ",promise.Args.Select(x=>$"{x.Value.GetNETType(false)} {x.Key}").ToArray())});

    private delegate void {fullName}_delegate_native({nativeArguments});

    [AOT.MonoPInvokeCallback(typeof({fullName}_delegate_native))]
    private static void {fullName}_promise({nativeArguments})
    {{
        {fullName}_promises[promise].AfterCallback(new object[] {{ {string.Join(", ", promise.Args.Select(x => x.Value.MarshalToNET(x.Key)).ToArray())} }});
    }}
");
                                    }

                                    csFile.Write($@"
    [DllImport(""__Internal"")]
    private static extern {returnType.GetMarshalType()} {fullName}(int id{string.Join("", arguments.Select(x => $", {x.Value.GetMarshalType()} {x.Key}").ToArray())}{(isPromise ? $", {fullName}_delegate_native callback" :"")});

    public {returnType.GetNETType(false)} {methodName}({netArguments}) {{
        {(shouldReturnValue ? "var value = " : "")}{fullName}(this.ID{argumentList}{(isPromise ? $", {fullName}_promise" : "")});
        {(shouldReturnValue ? $"return {returnType.MarshalToNET("value")};" : "")}
    }}
");

                                    jsLibElements.Add($@"
    {fullName} : function(id{string.Join("", arguments.Select(x => $", {x.Key}").ToArray())}{(isPromise ? $", callback" : "")}) {{
        {(shouldReturnValue ? "var value = " : "")}_WebIDL2Unity.references[id].{nativeName}({string.Join(", ", arguments.Select(x => $"{x.Value.MarshalToJS(x.Key)}").ToArray())});
        {(shouldReturnValue ? $"{returnType.JSToMarshalReturn("value", false)}" : "")}
    }}
");

                                }
                            }
                            break;

                        case "setlike":

                            break;

                        case "iterable":

                            break;

                        default:
                            throw new Exception("Unknown interface member type : " + type);
                    }


                }

                csFile.WriteLine("}");

                if (jsLibElements.Any())
                {
                    using (StreamWriter jsFile = GetFile(context.OutputDirectory, "jslib", _module + "_"))
                    {
                        jsFile.Write($@"
mergeInto(LibraryManager.library, {{
{string.Join(",\r\n", jsLibElements.ToArray())}
}});
");
                    }
                }


            }
        }


    }
}
