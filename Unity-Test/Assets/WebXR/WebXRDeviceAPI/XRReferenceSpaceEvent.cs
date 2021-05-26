
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRReferenceSpaceEvent : Event {


    internal XRReferenceSpaceEvent (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRReferenceSpaceEvent_2(string type, int eventInitDict);

    public XRReferenceSpaceEvent(string type, XRReferenceSpaceEventInit eventInitDict) : base(XRReferenceSpaceEvent_2(type, eventInitDict==null ? 0 : eventInitDict.ID)) { }


    public XRReferenceSpace ReferenceSpace {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "referenceSpace");
            return value == 0 ? null : new XRReferenceSpace(value);
        }
    }



    public XRRigidTransform Transform {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "transform");
            return value == 0 ? null : new XRRigidTransform(value);
        }
    }

}
