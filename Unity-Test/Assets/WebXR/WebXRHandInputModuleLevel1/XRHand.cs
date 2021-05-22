
using System;
using System.Runtime.InteropServices;

public  class XRHand : WebIDL2UnityObject {


    internal XRHand (int id) : base(id) {}



    public ulong Size {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "size");
            return value;
        }
    }


}
