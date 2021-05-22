
using System;
using System.Runtime.InteropServices;

public  class XRPermissionDescriptor : WebIDL2UnityObject {


    internal XRPermissionDescriptor (int id) : base(id) {}

    public XRPermissionDescriptor() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRSessionMode Mode {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "mode");
            return (XRSessionMode)value;
        }
        set {
            WebIDL2Unity_short_set(this.ID, "mode", (int)value);
        }
    }



    public Sequence<string> RequiredFeatures {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "requiredFeatures");
            return new Sequence<string>(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "requiredFeatures", value.ID);
        }
    }



    public Sequence<string> OptionalFeatures {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "optionalFeatures");
            return new Sequence<string>(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "optionalFeatures", value.ID);
        }
    }

}
