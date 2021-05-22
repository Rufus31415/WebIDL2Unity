
using System;
using System.Runtime.InteropServices;

public  class XRSessionSupportedPermissionDescriptor : WebIDL2UnityObject {


    internal XRSessionSupportedPermissionDescriptor (int id) : base(id) {}

    public XRSessionSupportedPermissionDescriptor() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRSessionMode Mode {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "mode");
            return (XRSessionMode)value;
        }
        set {
            WebIDL2Unity_short_set(this.ID, "mode", (int)value);
        }
    }

}
