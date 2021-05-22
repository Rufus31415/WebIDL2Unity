
using System;
using System.Runtime.InteropServices;

public  class XRReferenceSpaceEventInit : WebIDL2UnityObject {


    internal XRReferenceSpaceEventInit (int id) : base(id) {}

    public XRReferenceSpaceEventInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRReferenceSpace ReferenceSpace {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "referenceSpace");
            return value == 0 ? null : new XRReferenceSpace(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "referenceSpace", value.ID);
        }
    }



    public XRRigidTransform Transform {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "transform");
            return value == 0 ? null : new XRRigidTransform(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "transform", value.ID);
        }
    }

}
