
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRHitTestResult : WebIDL2UnityObject {



    private static readonly Dictionary<int, Promise<XRHitTestResult_CreateAnchor_delegate >> XRHitTestResult_CreateAnchor_promises = new Dictionary<int, Promise<XRHitTestResult_CreateAnchor_delegate>>();

    public delegate void XRHitTestResult_CreateAnchor_delegate(bool supported);

    private delegate void XRHitTestResult_CreateAnchor_delegate_native(int promise, bool supported);

    [AOT.MonoPInvokeCallback(typeof(XRHitTestResult_CreateAnchor_delegate_native))]
    private static void XRHitTestResult_CreateAnchor_promise(int promise, bool supported)
    {
        XRHitTestResult_CreateAnchor_promises[promise].AfterCallback(new object[] { supported });
    }

    [DllImport("__Internal")]
    private static extern int XRHitTestResult_CreateAnchor(int id, XRHitTestResult_CreateAnchor_delegate_native callback);

    public Promise<XRHitTestResult_CreateAnchor_delegate> CreateAnchor() {
        var value = XRHitTestResult_CreateAnchor(this.ID, XRHitTestResult_CreateAnchor_promise);
        return value == 0 ? null : new Promise<XRHitTestResult_CreateAnchor_delegate>(value, XRHitTestResult_CreateAnchor_promises);;
    }
}
