using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace WebIDL2Unity
{
    class TypedefIDLType : JSONIDLType
    {
        public readonly List<string> Types = new List<string>();

        public TypedefIDLType(JObject jproperty, string module) : base(jproperty, module)
        {
            foreach (var type in jproperty["idlType"]["idlType"])
            {
                Types.Add(type.Value<string>("idlType"));
            }
        }

        public override void Generate(GenerationContext context)
        {
            using (StreamWriter csFile = GetFile(context.OutputDirectory, "cs"))
            {
                csFile.Write($@"
public interface {Name} : IWebIDL2UnityObject {{}}
");
            }
        }


    }
}
