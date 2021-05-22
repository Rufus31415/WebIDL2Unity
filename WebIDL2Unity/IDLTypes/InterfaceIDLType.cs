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
        public InterfaceIDLType(JObject jproperty, string module, bool isDictionnary) : base(jproperty, module)
        {
            IsWebIDLPartial = (bool)_jProperty["partial"];
            IsDictionnary = isDictionnary;
        }

        private class Property
        {
            public string Type;
            public string Name;
        }

        public override void Generate(GenerationContext context)
        {
            var isNetPartialClass = context.IDLObjects.Count(x => string.Equals(x.Name, Name)) > 1;

            var writableProperties = new List<Property>();

            using (StreamWriter csFile = GetFile(context.OutputDirectory, "cs"))
            {
 /*               using (StreamWriter jslibFile = GetFile(context.OutputDirectory, "jslib"))
                {
 */
                    csFile.Write($@"
using System;
using System.Runtime.InteropServices;

public {(isNetPartialClass ? "partial " : "")} class {Name} : WebIDL2UnityObject {{
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

                                IDLType idlType;

                                var genericType = member["idlType"].Value<string>("generic");

                                if (!string.IsNullOrEmpty(genericType))
                                {
                                    var genericTypeName = member["idlType"]["idlType"][0].Value<string>("idlType");


                                    if (!context.IDLObjects.TryGetValue(genericTypeName, out IDLType elementType))
                                    {
                                        Console.WriteLine("Unknown IDL type for frozen array : " + genericTypeName);
                                        continue;
                                    }

                                    if (genericType == "FrozenArray") idlType = new FrozenArrayIDLType(elementType, $"FrozenArray<{elementType.GetNETType(false)}>");
                                    else if (genericType == "sequence") idlType = new SequenceIDLType(elementType, $"Sequence<{elementType.GetNETType(false)}>");
                                    else
                                    {
                                        Console.WriteLine("Unknown Generic IDL type : " + genericType);
                                        continue;
                                    }
                                }
                                else
                                {
                                    var typeName = member["idlType"].Value<string>("idlType");

                                    if (!context.IDLObjects.TryGetValue(typeName, out idlType))
                                    {
                                        Console.WriteLine("Unknown IDL type : " + typeName);
                                        continue;
                                    }
                                }

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

                                break;

                            case "constructor":

                                break;

                            case "setlike":

                                break;

                            case "iterable":

                                break;

                            default:
                                throw new Exception("Unknown interface member type : " + type);
                        }


                    }

                        /* Warning : doesnt work for partial class
                    if (IsDictionnary && !isNetPartialClass)
                    {
                        // constructor with all properties
                        csFile.Write($@"
    public {Name}({string.Join(", ", writableProperties.Select(x => $"{x.Type} {x.Name}").ToArray())}) : base(GetNewDictionnary()) {{
");


                        writableProperties.ForEach(x => csFile.Write($@"
    this.{x.Name} = {x.Name};"));

                        csFile.WriteLine(@"
    }");

                        // default public constructor
                        csFile.WriteLine($@"
    public {Name}() : base(GetNewDictionnary()) {{ }}");

                    }
                */


 //                   jslibFile.WriteLine("});");
                    csFile.WriteLine("}");


                }
            }
 //       }


    }
}
