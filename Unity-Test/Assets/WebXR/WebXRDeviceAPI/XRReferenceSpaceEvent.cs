
using System;
using System.Runtime.InteropServices;

public  class XRReferenceSpaceEvent : WebIDL2UnityObject {


    internal XRReferenceSpaceEvent (int id) : base(id) {}



    public XRReferenceSpace ReferenceSpace {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "referenceSpace");
            return value == 0 ? null : new XRReferenceSpace(value);
        }
    }



    public XRRigidTransform Transform {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "transform");
            return value == 0 ? null : new XRRigidTransform(value);
        }
    }

}
