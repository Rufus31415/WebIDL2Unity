using System.IO;

namespace WebIDL2Unity
{
    internal class PrimitiveIDLType : IDLType
    {

        private string _netType;

        public PrimitiveIDLType(string idlName, string netType) : base(idlName, "Native")
        {
            _netType = netType;
        }

        public override string GetMarshalType()
        {
            return _netType;
        }

        public override string GetNETType(bool nullable)
        {
            //return _netType + (nullable ? "?" : "");
            return _netType;
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
            return variable;
        }

        public override string GetterName()
        {
            return $"WebIDL2Unity_{Name.Replace(" ", "_")}_get";
        }

        public override string SetterName()
        {
            return $"WebIDL2Unity_{Name.Replace(" ", "_")}_set";
        }

        public static void GeneratePrimitive(IDLType type, GenerationContext context)
        {
            using (StreamWriter csFile = type.GetFile(context.OutputDirectory, "cs"))
            {
                using (StreamWriter jslibFile = type.GetFile(context.OutputDirectory, "jslib"))
                {
                    csFile.Write($@"
using System;
using System.Runtime.InteropServices;

public abstract partial class WebIDL2UnityObject
{{
     [DllImport(""__Internal"")]
    protected extern static {type.GetMarshalType()} {type.GetterName()}(int parentID, string fieldName);

     [DllImport(""__Internal"")]
    protected extern static void {type.SetterName()}(int parentID, string fieldName, {type.GetMarshalType()} value);

}}");

                    jslibFile.Write($@"
mergeInto(LibraryManager.library, {{
    {type.GetterName()} : function(parentID, fieldName){{
       return {type.JSToMarshal("_WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)]", false)};
    }},
    {type.SetterName()} : function(parentID, fieldName, value){{
        _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = {type.MarshalToJS("value")};
    }}
}});
");

                }
            }
        }

        public override void Generate(GenerationContext context)
        {
            GeneratePrimitive(this, context);
        }
    }
}
