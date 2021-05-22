
using System;
using System.Runtime.InteropServices;

public partial  class Navigator : WebIDL2UnityObject {


    public XRSystem Xr {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "xr");
            return value == 0 ? null : new XRSystem(value);
        }
    }

}
