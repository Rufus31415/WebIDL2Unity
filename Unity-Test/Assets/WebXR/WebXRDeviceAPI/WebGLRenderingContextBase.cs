
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class WebGLRenderingContextBase : WebIDL2UnityObject {



    private static readonly Dictionary<int, Promise<WebGLRenderingContextBase_MakeXRCompatible_delegate >> WebGLRenderingContextBase_MakeXRCompatible_promises = new Dictionary<int, Promise<WebGLRenderingContextBase_MakeXRCompatible_delegate>>();

    public delegate void WebGLRenderingContextBase_MakeXRCompatible_delegate(bool supported);

    private delegate void WebGLRenderingContextBase_MakeXRCompatible_delegate_native(int promise, bool supported);

    [AOT.MonoPInvokeCallback(typeof(WebGLRenderingContextBase_MakeXRCompatible_delegate_native))]
    private static void WebGLRenderingContextBase_MakeXRCompatible_promise(int promise, bool supported)
    {
        WebGLRenderingContextBase_MakeXRCompatible_promises[promise].AfterCallback(new object[] { supported });
    }

    [DllImport("__Internal")]
    private static extern int WebGLRenderingContextBase_MakeXRCompatible(int id, WebGLRenderingContextBase_MakeXRCompatible_delegate_native callback);

    public Promise<WebGLRenderingContextBase_MakeXRCompatible_delegate> MakeXRCompatible() {
        var value = WebGLRenderingContextBase_MakeXRCompatible(this.ID, WebGLRenderingContextBase_MakeXRCompatible_promise);
        return value == 0 ? null : new Promise<WebGLRenderingContextBase_MakeXRCompatible_delegate>(value, WebGLRenderingContextBase_MakeXRCompatible_promises);;
    }
}
