using Newtonsoft.Json.Linq;
using System.Linq;

namespace WebIDL2Unity
{
    internal class SequenceIDLType : IDLType
    {
        IDLType _elementType;
        bool _isFrozen;

        PrimitiveArrayIDLType _sequenceType;

        public SequenceIDLType(IDLType elementType, bool isFrozen, GenerationContext context) : base(isFrozen ? $"FrozenArray<{ elementType.GetNETType(false)}>" : $"Sequence<{elementType.GetNETType(false)}>", "Native")
        {
            _elementType = elementType;
            _isFrozen = isFrozen;

            _sequenceType = context.IDLObjects.OfType<PrimitiveArrayIDLType>().FirstOrDefault(x => string.Equals(x.ElementType.Name, elementType.Name));
        }

        public override void Generate(GenerationContext context)
        {
            
        }


        public override string GetNETType(bool nullable)
        {
            if (_isFrozen) return $"FrozenArray<{_elementType.GetNETType(false)}>";
            else if (_sequenceType != null) return _sequenceType.GetNETType(nullable);
            else if(_elementType is EnumIDLType) return $"EnumArray<{_elementType.GetNETType(false)}>";
            else return $"JSArray<{_elementType.GetNETType(false)}>";
        }

        public override string MarshalToNET(string nativeValue)
        {
            if (_sequenceType != null) return _sequenceType.MarshalToNET(nativeValue);

            return $"new {(_elementType is EnumIDLType ? "EnumArray" : "JSArray")}<{_elementType.GetNETType(false)}>({nativeValue})";
        }
    }
}