
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRSession : EventTarget {



    private static readonly Dictionary<int, Promise<XRSession_RequestLightProbe_delegate >> XRSession_RequestLightProbe_promises = new Dictionary<int, Promise<XRSession_RequestLightProbe_delegate>>();

    public delegate void XRSession_RequestLightProbe_delegate(XRLightProbe a0);

    private delegate void XRSession_RequestLightProbe_delegate_native(int promise, int a0);

    [AOT.MonoPInvokeCallback(typeof(XRSession_RequestLightProbe_delegate_native))]
    private static void XRSession_RequestLightProbe_promise(int promise, int a0)
    {
        XRSession_RequestLightProbe_promises[promise].AfterCallback(new object[] { a0 == 0 ? null : new XRLightProbe(a0) });
    }

    [DllImport("__Internal")]
    private static extern int XRSession_RequestLightProbe(int id, int options, XRSession_RequestLightProbe_delegate_native callback);

    public Promise<XRSession_RequestLightProbe_delegate> RequestLightProbe(XRLightProbeInit options) {
        var value = XRSession_RequestLightProbe(this.ID, options==null ? 0 : options.ID, XRSession_RequestLightProbe_promise);
        return value == 0 ? null : new Promise<XRSession_RequestLightProbe_delegate>(value, XRSession_RequestLightProbe_promises);
    }


    public XRReflectionFormat PreferredReflectionFormat {
        get {
            var value = WebIDL2Unity_XRReflectionFormat_get(this.ID, "preferredReflectionFormat");
            return (XRReflectionFormat)value;
        }
    }

}
