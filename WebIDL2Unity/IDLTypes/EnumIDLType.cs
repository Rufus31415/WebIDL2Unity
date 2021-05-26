using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WebIDL2Unity
{
    class EnumIDLType : JSONIDLType
    {
        public class EnumIDLValue
        {
            public string IDLName;
            public string NETName;
            public int Value;
        }

        private List<EnumIDLValue> _values = new List<EnumIDLValue>();

        public override string GetterName()
        {
            return $"WebIDL2Unity_{Name.Replace(" ", "_")}_get";
        }

        public override string SetterName()
        {
            return $"WebIDL2Unity_{Name.Replace(" ", "_")}_set";
        }

        public EnumIDLType(JObject jproperty, string module) : base(jproperty, module)
        {
            int i = 0;

            foreach (var enumValue in jproperty["values"])
            {
                var idlValue = new EnumIDLValue();

                idlValue.IDLName = enumValue.Value<string>("value");

                idlValue.Value = i;

                idlValue.NETName = Helper.JavascriptToNETName(idlValue.IDLName);

                _values.Add(idlValue);

                i++;
            }
        }


        public override void Generate(GenerationContext context)
        {
            using (StreamWriter jsFile = GetFile(context.OutputDirectory, "jspre"))
            {
                jsFile.Write($@"
if(typeof _WebIDL2UnityEnums == ""undefined"") _WebIDL2UnityEnums = {{}}

_WebIDL2UnityEnums.{Name} = {{
");

                jsFile.Write(string.Join(",\r\n", _values.Select(value => $"\"{value.IDLName}\":{value.Value}").ToArray()));
                jsFile.WriteLine(",");
                jsFile.WriteLine(string.Join(",\r\n", _values.Select(value => $"\"{value.Value}\":\"{value.IDLName}\"").ToArray()));

                jsFile.WriteLine("}");
            }

            using (StreamWriter csFile = GetFile(context.OutputDirectory, "cs"))
            {
                csFile.Write($@"
using System;
using System.Runtime.InteropServices;

public enum {Name} {{
{string.Join(",\r\n", _values.Select((x) => $"{x.NETName} = {x.Value}").ToArray())}
}}


public abstract partial class WebIDL2UnityObject
{{
     [DllImport(""__Internal"")]
    protected extern static {GetMarshalType()} {GetterName()}(int parentID, string fieldName);

     [DllImport(""__Internal"")]
    protected extern static void {SetterName()}(int parentID, string fieldName, {GetMarshalType()} value);

}}
");

                using (StreamWriter jslibFile = GetFile(context.OutputDirectory, "jslib"))
                {
                    jslibFile.Write($@"
mergeInto(LibraryManager.library, {{
    {GetterName()} : function(parentID, fieldName){{
       return {JSFullName}[_WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)]];
    }},
    {SetterName()} : function(parentID, fieldName, value){{
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = {JSFullName}[value];
    }}
}});
");
                }

            }
        }

        public string JSFullName => $"_WebIDL2UnityEnums.{Name}";

        public override string MarshalToNET(string nativeValue)
        {
            return $"({Name}){nativeValue}";
        }
        public override string NETToMarshal(string netValue)
        {
            return $"(int){netValue}";
        }

        public override string MarshalToJS(string variable)
        {
            return $"{JSFullName}[{variable}]";
        }

        public override string GetNETType(bool nullable)
        {
            if (nullable) return Name + "?";
            else return Name;
        }
    }
}
