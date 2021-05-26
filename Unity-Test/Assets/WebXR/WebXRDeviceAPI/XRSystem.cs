
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRSystem : EventTarget {


    internal XRSystem (int id) : base(id) {}



    private static readonly Dictionary<int, Promise<XRSystem_IsSessionSupported_delegate >> XRSystem_IsSessionSupported_promises = new Dictionary<int, Promise<XRSystem_IsSessionSupported_delegate>>();

    public delegate void XRSystem_IsSessionSupported_delegate(bool supported);

    private delegate void XRSystem_IsSessionSupported_delegate_native(int promise, bool supported);

    [AOT.MonoPInvokeCallback(typeof(XRSystem_IsSessionSupported_delegate_native))]
    private static void XRSystem_IsSessionSupported_promise(int promise, bool supported)
    {
        XRSystem_IsSessionSupported_promises[promise].AfterCallback(new object[] { supported });
    }

    [DllImport("__Internal")]
    private static extern int XRSystem_IsSessionSupported(int id, int mode, XRSystem_IsSessionSupported_delegate_native callback);

    public Promise<XRSystem_IsSessionSupported_delegate> IsSessionSupported(XRSessionMode mode) {
        var value = XRSystem_IsSessionSupported(this.ID, (int)mode, XRSystem_IsSessionSupported_promise);
        return value == 0 ? null : new Promise<XRSystem_IsSessionSupported_delegate>(value, XRSystem_IsSessionSupported_promises);;
    }



    private static readonly Dictionary<int, Promise<XRSystem_RequestSession_delegate >> XRSystem_RequestSession_promises = new Dictionary<int, Promise<XRSystem_RequestSession_delegate>>();

    public delegate void XRSystem_RequestSession_delegate(bool supported);

    private delegate void XRSystem_RequestSession_delegate_native(int promise, bool supported);

    [AOT.MonoPInvokeCallback(typeof(XRSystem_RequestSession_delegate_native))]
    private static void XRSystem_RequestSession_promise(int promise, bool supported)
    {
        XRSystem_RequestSession_promises[promise].AfterCallback(new object[] { supported });
    }

    [DllImport("__Internal")]
    private static extern int XRSystem_RequestSession(int id, int mode, int options, XRSystem_RequestSession_delegate_native callback);

    public Promise<XRSystem_RequestSession_delegate> RequestSession(XRSessionMode mode, XRSessionInit options) {
        var value = XRSystem_RequestSession(this.ID, (int)mode, options==null ? 0 : options.ID, XRSystem_RequestSession_promise);
        return value == 0 ? null : new Promise<XRSystem_RequestSession_delegate>(value, XRSystem_RequestSession_promises);;
    }


    public EventHandler Ondevicechange {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "ondevicechange");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "ondevicechange", value==null ? 0 : value.ID);
        }
    }

}
