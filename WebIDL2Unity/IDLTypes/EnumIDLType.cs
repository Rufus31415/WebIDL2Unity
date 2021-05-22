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
                jsFile.Write(JSFullName);
                jsFile.WriteLine(" = {");

                jsFile.Write(string.Join(",\r\n", _values.Select(value => $"\"{value.IDLName}\":{value.Value}").ToArray()));
                jsFile.WriteLine(",");
                jsFile.WriteLine(string.Join(",\r\n", _values.Select(value => $"\"{value.Value}\":\"{value.IDLName}\"").ToArray()));

                jsFile.WriteLine("}");
            }

            using (StreamWriter csFile = GetFile(context.OutputDirectory, "cs"))
            {
                csFile.Write("public enum ");
                csFile.Write(Name);
                csFile.WriteLine("{");

                csFile.WriteLine(string.Join(",\r\n", _values.Select((x) => $"{x.NETName} = {x.Value}").ToArray()));

                csFile.WriteLine("}");

            }
        }

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
