
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRTransientInputHitTestOptionsInit : WebIDL2UnityObject {


    internal XRTransientInputHitTestOptionsInit (int id) : base(id) {}

    public XRTransientInputHitTestOptionsInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public string Profile {
        get {
            var value = WebIDL2Unity_DOMString_get(this.ID, "profile");
            return value;
        }
        set {
            WebIDL2Unity_DOMString_set(this.ID, "profile", value);
        }
    }



    public EnumArray<XRHitTestTrackableType> EntityTypes {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "entityTypes");
            return new EnumArray<XRHitTestTrackableType>(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "entityTypes", value==null ? 0 : value.ID);
        }
    }



    public XRRay OffsetRay {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "offsetRay");
            return value == 0 ? null : new XRRay(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "offsetRay", value==null ? 0 : value.ID);
        }
    }

}
