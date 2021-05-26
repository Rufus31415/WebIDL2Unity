
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRFrame : WebIDL2UnityObject {



    private static readonly Dictionary<int, Promise<XRFrame_CreateAnchor_delegate >> XRFrame_CreateAnchor_promises = new Dictionary<int, Promise<XRFrame_CreateAnchor_delegate>>();

    public delegate void XRFrame_CreateAnchor_delegate(bool supported);

    private delegate void XRFrame_CreateAnchor_delegate_native(int promise, bool supported);

    [AOT.MonoPInvokeCallback(typeof(XRFrame_CreateAnchor_delegate_native))]
    private static void XRFrame_CreateAnchor_promise(int promise, bool supported)
    {
        XRFrame_CreateAnchor_promises[promise].AfterCallback(new object[] { supported });
    }

    [DllImport("__Internal")]
    private static extern int XRFrame_CreateAnchor(int id, int pose, int space, XRFrame_CreateAnchor_delegate_native callback);

    public Promise<XRFrame_CreateAnchor_delegate> CreateAnchor(XRRigidTransform pose, XRSpace space) {
        var value = XRFrame_CreateAnchor(this.ID, pose==null ? 0 : pose.ID, space==null ? 0 : space.ID, XRFrame_CreateAnchor_promise);
        return value == 0 ? null : new Promise<XRFrame_CreateAnchor_delegate>(value, XRFrame_CreateAnchor_promises);;
    }


    public XRAnchorSet TrackedAnchors {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "trackedAnchors");
            return value == 0 ? null : new XRAnchorSet(value);
        }
    }

}
