
using System;
using System.Runtime.InteropServices;

public  class XRPermissionStatus : WebIDL2UnityObject {


    internal XRPermissionStatus (int id) : base(id) {}


    public FrozenArray<string> Granted {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "granted");
            return new FrozenArray<string>(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "granted", value.ID);
        }
    }

}
