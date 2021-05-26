
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRReferenceSpaceEventInit : EventInit {


    internal XRReferenceSpaceEventInit (int id) : base(id) {}

    public XRReferenceSpaceEventInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRReferenceSpace ReferenceSpace {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "referenceSpace");
            return value == 0 ? null : new XRReferenceSpace(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "referenceSpace", value==null ? 0 : value.ID);
        }
    }



    public XRRigidTransform Transform {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "transform");
            return value == 0 ? null : new XRRigidTransform(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "transform", value==null ? 0 : value.ID);
        }
    }

}
