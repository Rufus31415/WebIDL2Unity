
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRHand : WebIDL2UnityObject {


    internal XRHand (int id) : base(id) {}



    public ulong Size {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "size");
            return value;
        }
    }



    [DllImport("__Internal")]
    private static extern int XRHand_Get(int id, int key);

    public XRJointSpace Get(XRHandJoint key) {
        var value = XRHand_Get(this.ID, (int)key);
        return value == 0 ? null : new XRJointSpace(value);
    }
}
