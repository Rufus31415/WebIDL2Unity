
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRSession : EventTarget {



    private static readonly Dictionary<int, Promise<XRSession_RequestHitTestSource_delegate >> XRSession_RequestHitTestSource_promises = new Dictionary<int, Promise<XRSession_RequestHitTestSource_delegate>>();

    public delegate void XRSession_RequestHitTestSource_delegate(bool supported);

    private delegate void XRSession_RequestHitTestSource_delegate_native(int promise, bool supported);

    [AOT.MonoPInvokeCallback(typeof(XRSession_RequestHitTestSource_delegate_native))]
    private static void XRSession_RequestHitTestSource_promise(int promise, bool supported)
    {
        XRSession_RequestHitTestSource_promises[promise].AfterCallback(new object[] { supported });
    }

    [DllImport("__Internal")]
    private static extern int XRSession_RequestHitTestSource(int id, int options, XRSession_RequestHitTestSource_delegate_native callback);

    public Promise<XRSession_RequestHitTestSource_delegate> RequestHitTestSource(XRHitTestOptionsInit options) {
        var value = XRSession_RequestHitTestSource(this.ID, options==null ? 0 : options.ID, XRSession_RequestHitTestSource_promise);
        return value == 0 ? null : new Promise<XRSession_RequestHitTestSource_delegate>(value, XRSession_RequestHitTestSource_promises);;
    }



    private static readonly Dictionary<int, Promise<XRSession_RequestHitTestSourceForTransientInput_delegate >> XRSession_RequestHitTestSourceForTransientInput_promises = new Dictionary<int, Promise<XRSession_RequestHitTestSourceForTransientInput_delegate>>();

    public delegate void XRSession_RequestHitTestSourceForTransientInput_delegate(bool supported);

    private delegate void XRSession_RequestHitTestSourceForTransientInput_delegate_native(int promise, bool supported);

    [AOT.MonoPInvokeCallback(typeof(XRSession_RequestHitTestSourceForTransientInput_delegate_native))]
    private static void XRSession_RequestHitTestSourceForTransientInput_promise(int promise, bool supported)
    {
        XRSession_RequestHitTestSourceForTransientInput_promises[promise].AfterCallback(new object[] { supported });
    }

    [DllImport("__Internal")]
    private static extern int XRSession_RequestHitTestSourceForTransientInput(int id, int options, XRSession_RequestHitTestSourceForTransientInput_delegate_native callback);

    public Promise<XRSession_RequestHitTestSourceForTransientInput_delegate> RequestHitTestSourceForTransientInput(XRTransientInputHitTestOptionsInit options) {
        var value = XRSession_RequestHitTestSourceForTransientInput(this.ID, options==null ? 0 : options.ID, XRSession_RequestHitTestSourceForTransientInput_promise);
        return value == 0 ? null : new Promise<XRSession_RequestHitTestSourceForTransientInput_delegate>(value, XRSession_RequestHitTestSourceForTransientInput_promises);;
    }
}
