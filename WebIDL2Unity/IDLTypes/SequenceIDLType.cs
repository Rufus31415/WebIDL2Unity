using Newtonsoft.Json.Linq;
using System.Linq;

namespace WebIDL2Unity
{
    public class SequenceIDLType : IDLType
    {
        public IDLType ElementType;
        bool _isFrozen;

        PrimitiveArrayIDLType _sequenceType;

        public SequenceIDLType(IDLType elementType, bool isFrozen, GenerationContext context) : base(isFrozen ? $"FrozenArray<{ elementType.GetNETType(false)}>" : $"Sequence<{elementType.GetNETType(false)}>", "Native")
        {
            ElementType = elementType;
            _isFrozen = isFrozen;

            _sequenceType = context.IDLObjects.OfType<PrimitiveArrayIDLType>().FirstOrDefault(x => string.Equals(x.ElementType.Name, elementType.Name));
        }

        public override void Generate(GenerationContext context)
        {
            
        }


        public override string GetNETType(bool nullable)
        {
            if (_isFrozen) return $"FrozenArray<{ElementType.GetNETType(false)}>";
            else if (_sequenceType != null) return _sequenceType.GetNETType(nullable);
            else if(ElementType is EnumIDLType) return $"EnumArray<{ElementType.GetNETType(false)}>";
            else return $"JSArray<{ElementType.GetNETType(false)}>";
        }

        public override string MarshalToNET(string nativeValue)
        {
            if (_sequenceType != null) return _sequenceType.MarshalToNET(nativeValue);

            return $"new {(ElementType is EnumIDLType ? "EnumArray" : "JSArray")}<{ElementType.GetNETType(false)}>({nativeValue})";
        }
    }
}