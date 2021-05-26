
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRInputSource : WebIDL2UnityObject {


    internal XRInputSource (int id) : base(id) {}


    public XRHandedness Handedness {
        get {
            var value = WebIDL2Unity_XRHandedness_get(this.ID, "handedness");
            return (XRHandedness)value;
        }
    }



    public XRTargetRayMode TargetRayMode {
        get {
            var value = WebIDL2Unity_XRTargetRayMode_get(this.ID, "targetRayMode");
            return (XRTargetRayMode)value;
        }
    }



    public XRSpace TargetRaySpace {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "targetRaySpace");
            return value == 0 ? null : new XRSpace(value);
        }
    }



    public XRSpace GripSpace {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "gripSpace");
            return value == 0 ? null : new XRSpace(value);
        }
    }



    public StringArray Profiles {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "profiles");
            return value == 0 ? null : new StringArray(value);
        }
    }

}
