
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRHitTestOptionsInit : WebIDL2UnityObject {


    internal XRHitTestOptionsInit (int id) : base(id) {}

    public XRHitTestOptionsInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRSpace Space {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "space");
            return value == 0 ? null : new XRSpace(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "space", value==null ? 0 : value.ID);
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
