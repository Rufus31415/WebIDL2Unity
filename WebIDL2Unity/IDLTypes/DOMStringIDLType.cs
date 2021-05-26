using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WebIDL2Unity
{
    internal class DOMStringIDLType : IDLType
    {

        public DOMStringIDLType(string idlName = "DOMString") : base(idlName, "Native")
        {
        }

        public override string GetMarshalType()
        {
            return "string";
        }

        public override string GetNETType(bool nullable)
        {
            return "string";
        }

        public override string GetterName()
        {
            return $"WebIDL2Unity_{Name.Replace(" ", "_")}_get";
        }

        public override string SetterName()
        {
            return $"WebIDL2Unity_{Name.Replace(" ", "_")}_set";
        }

        public override string MarshalToNET(string nativeValue)
        {
            return nativeValue;
        }

        public override string NETToMarshal(string netValue)
        {            
            return netValue;
        }

        public override string MarshalToJS(string variable)
        {
            return $"Pointer_stringify({variable})";
        }

        public override string JSToMarshal(string variable, bool nullable)
        {
            return $"WebIDL2UnityStringToPtr({variable})";
        }

        public override void Generate(GenerationContext context)
        {
            PrimitiveIDLType.GeneratePrimitive(this, context);
        }
    }
}
