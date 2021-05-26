
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRReferenceSpace : XRSpace {


    internal XRReferenceSpace (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRReferenceSpace_GetOffsetReferenceSpace(int id, int originOffset);

    public XRReferenceSpace GetOffsetReferenceSpace(XRRigidTransform originOffset) {
        var value = XRReferenceSpace_GetOffsetReferenceSpace(this.ID, originOffset==null ? 0 : originOffset.ID);
        return value == 0 ? null : new XRReferenceSpace(value);
    }


    public EventHandler Onreset {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "onreset");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "onreset", value==null ? 0 : value.ID);
        }
    }

}
