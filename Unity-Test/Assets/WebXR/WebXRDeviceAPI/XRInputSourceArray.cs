
using System;
using System.Runtime.InteropServices;

public  class XRInputSourceArray : WebIDL2UnityObject {


    internal XRInputSourceArray (int id) : base(id) {}



    public ulong Length {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "length");
            return value;
        }
    }


}
