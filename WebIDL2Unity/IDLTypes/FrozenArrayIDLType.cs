using Newtonsoft.Json.Linq;

namespace WebIDL2Unity
{
    internal class FrozenArrayIDLType : IDLType
    {
        IDLType _elementType;

        public FrozenArrayIDLType(IDLType elementType, string idlName) : base(idlName, "Native")
        {
            _elementType = elementType;
        }

        public override void Generate(GenerationContext context)
        {
            
        }


        public override string GetNETType(bool nullable)
        {
            return $"FrozenArray<{_elementType.GetNETType(false)}>";
        }

        public override string MarshalToNET(string nativeValue)
        {
            return $"new {GetNETType(false)}({nativeValue})";
        }

    }
}