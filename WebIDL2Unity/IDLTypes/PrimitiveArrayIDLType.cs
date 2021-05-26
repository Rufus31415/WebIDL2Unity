using System.IO;

namespace WebIDL2Unity
{
    internal class PrimitiveArrayIDLType : IDLType
    {
        public readonly IDLType ElementType;

        public PrimitiveArrayIDLType(IDLType elementType, string idlName) : base(idlName, "Native")
        {
            ElementType = elementType;
        }

        public override void Generate(GenerationContext context)
        {
            using (StreamWriter csFile = GetFile(context.OutputDirectory, "cs"))
            {
                csFile.Write($@"
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class {Name} : Sequence<{ElementType.GetNETType(false)}>
{{
    internal {Name}(int id) : base(id)
    {{

    }}

    public {Name}() : base()
    {{

    }}

    [DllImport(""__Internal"")]
    private static extern {ElementType.GetNETType(false)} WebIDL2UnityGetElementAtNative_{Name}(int id, int index);

    public override {ElementType.GetNETType(false)} GetElementAt(int index)
    {{
        return WebIDL2UnityGetElementAtNative_{Name}(ID, index);
    }}

    [DllImport(""__Internal"")]
    private static extern void WebIDL2UnitySpliceNative_{Name}_3(int id, int start, int deleteCount, {ElementType.GetNETType(false)} item);

    public override void Splice(int start, int deleteCount, {ElementType.GetNETType(false)} item)
    {{
        WebIDL2UnitySpliceNative_{Name}_3(ID, start, deleteCount, item);
    }}

    [DllImport(""__Internal"")]
    private static extern void WebIDL2UnitySpliceNative_{Name}_2(int id, int start, int deleteCount);

    public override void Splice(int start, int deleteCount)
    {{
        WebIDL2UnitySpliceNative_{Name}_2(ID, start, deleteCount);
    }}


    [DllImport(""__Internal"")]
    private static extern int WebIDL2UnityIndexOfNative_{Name}(int id, {ElementType.GetNETType(false)} item);
    public override int IndexOf({ElementType.GetNETType(false)} item)
    {{
        return WebIDL2UnityIndexOfNative_{Name}(ID, item);
    }}


    public static implicit operator {Name}({ElementType.GetNETType(false)}[] x)
    {{
        var array = new {Name}();
        array.AddRange(x);
        return array;
    }}
}}
    ");
            }

            using (StreamWriter jslibFile = GetFile(context.OutputDirectory, "jslib"))
            {

                jslibFile.Write($@"
mergeInto(LibraryManager.library, {{
    WebIDL2UnityGetElementAtNative_{Name} : function(id, index){{
        return _WebIDL2Unity.references[id][index];
    }},

    WebIDL2UnitySpliceNative_{Name}_3 : function(id, start, deleteCount, item){{
            _WebIDL2Unity.references[id].splice(start, deleteCount, item);
    }},
    WebIDL2UnitySpliceNative_{Name}_2 : function(id, start, deleteCount){{
            _WebIDL2Unity.references[id].splice(start, deleteCount);
    }},

    WebIDL2UnityIndexOfNative_{Name} : function(id, item){{
        return _WebIDL2Unity.references[id].indexOf(item);
    }}
}});
");
            }
        }

    }
}