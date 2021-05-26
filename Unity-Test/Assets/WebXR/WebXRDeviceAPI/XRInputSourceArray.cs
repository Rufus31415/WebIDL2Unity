
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRInputSourceArray : WebIDL2UnityObject {


    internal XRInputSourceArray (int id) : base(id) {}



    public ulong Length {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "length");
            return value;
        }
    }



    public XRInputSource this[ulong index]
    {
        get
        {
            var value = WebIDL2Unity_reference_get(this.ID, index.ToString());
            return value == 0 ? null : new XRInputSource(value);
        }
    }
}
