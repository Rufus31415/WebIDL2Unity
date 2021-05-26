
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRFrame : WebIDL2UnityObject {


    internal XRFrame (int id) : base(id) {}


    public XRSession Session {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "session");
            return value == 0 ? null : new XRSession(value);
        }
    }



    [DllImport("__Internal")]
    private static extern int XRFrame_GetViewerPose(int id, int referenceSpace);

    public XRViewerPose GetViewerPose(XRReferenceSpace referenceSpace) {
        var value = XRFrame_GetViewerPose(this.ID, referenceSpace==null ? 0 : referenceSpace.ID);
        return value == 0 ? null : new XRViewerPose(value);
    }


    [DllImport("__Internal")]
    private static extern int XRFrame_GetPose(int id, int space, int baseSpace);

    public XRPose GetPose(XRSpace space, XRSpace baseSpace) {
        var value = XRFrame_GetPose(this.ID, space==null ? 0 : space.ID, baseSpace==null ? 0 : baseSpace.ID);
        return value == 0 ? null : new XRPose(value);
    }
}
