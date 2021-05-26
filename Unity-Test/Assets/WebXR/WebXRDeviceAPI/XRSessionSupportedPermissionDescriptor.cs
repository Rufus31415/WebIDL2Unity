
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRSessionSupportedPermissionDescriptor : PermissionDescriptor {


    internal XRSessionSupportedPermissionDescriptor (int id) : base(id) {}

    public XRSessionSupportedPermissionDescriptor() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRSessionMode Mode {
        get {
            var value = WebIDL2Unity_XRSessionMode_get(this.ID, "mode");
            return (XRSessionMode)value;
        }
        set {
            WebIDL2Unity_XRSessionMode_set(this.ID, "mode", (int)value);
        }
    }

}
