
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRPermissionDescriptor : PermissionDescriptor {


    internal XRPermissionDescriptor (int id) : base(id) {}

    public XRPermissionDescriptor() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRSessionMode Mode {
        get {
            var value = WebIDL2Unity_XRSessionMode_get(this.ID, "mode");
            return (XRSessionMode)value;
        }
        set {
            WebIDL2Unity_XRSessionMode_set(this.ID, "mode", (int)value);
        }
    }



    public FrozenArray<string> RequiredFeatures {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "requiredFeatures");
            return value == 0 ? null : new StringArray(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "requiredFeatures", value==null ? 0 : value.ID);
        }
    }



    public FrozenArray<string> OptionalFeatures {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "optionalFeatures");
            return value == 0 ? null : new StringArray(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "optionalFeatures", value==null ? 0 : value.ID);
        }
    }

}
