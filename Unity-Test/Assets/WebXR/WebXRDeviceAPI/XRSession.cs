
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRSession : EventTarget {


    internal XRSession (int id) : base(id) {}


    public XRVisibilityState VisibilityState {
        get {
            var value = WebIDL2Unity_XRVisibilityState_get(this.ID, "visibilityState");
            return (XRVisibilityState)value;
        }
    }



    public XRRenderState RenderState {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "renderState");
            return value == 0 ? null : new XRRenderState(value);
        }
    }



    public XRInputSourceArray InputSources {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "inputSources");
            return value == 0 ? null : new XRInputSourceArray(value);
        }
    }



    [DllImport("__Internal")]
    private static extern int XRSession_UpdateRenderState(int id, int state);

    public void UpdateRenderState(XRRenderStateInit state) {
        XRSession_UpdateRenderState(this.ID, state==null ? 0 : state.ID);
        
    }



    private static readonly Dictionary<int, Promise<XRSession_RequestReferenceSpace_delegate >> XRSession_RequestReferenceSpace_promises = new Dictionary<int, Promise<XRSession_RequestReferenceSpace_delegate>>();

    public delegate void XRSession_RequestReferenceSpace_delegate(bool supported);

    private delegate void XRSession_RequestReferenceSpace_delegate_native(int promise, bool supported);

    [AOT.MonoPInvokeCallback(typeof(XRSession_RequestReferenceSpace_delegate_native))]
    private static void XRSession_RequestReferenceSpace_promise(int promise, bool supported)
    {
        XRSession_RequestReferenceSpace_promises[promise].AfterCallback(new object[] { supported });
    }

    [DllImport("__Internal")]
    private static extern int XRSession_RequestReferenceSpace(int id, int type, XRSession_RequestReferenceSpace_delegate_native callback);

    public Promise<XRSession_RequestReferenceSpace_delegate> RequestReferenceSpace(XRReferenceSpaceType type) {
        var value = XRSession_RequestReferenceSpace(this.ID, (int)type, XRSession_RequestReferenceSpace_promise);
        return value == 0 ? null : new Promise<XRSession_RequestReferenceSpace_delegate>(value, XRSession_RequestReferenceSpace_promises);;
    }


    [DllImport("__Internal")]
    private static extern ulong XRSession_RequestAnimationFrame(int id);

    public ulong RequestAnimationFrame() {
        var value = XRSession_RequestAnimationFrame(this.ID);
        return value;
    }


    [DllImport("__Internal")]
    private static extern int XRSession_CancelAnimationFrame(int id, ulong handle);

    public void CancelAnimationFrame(ulong handle) {
        XRSession_CancelAnimationFrame(this.ID, handle);
        
    }



    private static readonly Dictionary<int, Promise<XRSession_End_delegate >> XRSession_End_promises = new Dictionary<int, Promise<XRSession_End_delegate>>();

    public delegate void XRSession_End_delegate(bool supported);

    private delegate void XRSession_End_delegate_native(int promise, bool supported);

    [AOT.MonoPInvokeCallback(typeof(XRSession_End_delegate_native))]
    private static void XRSession_End_promise(int promise, bool supported)
    {
        XRSession_End_promises[promise].AfterCallback(new object[] { supported });
    }

    [DllImport("__Internal")]
    private static extern int XRSession_End(int id, XRSession_End_delegate_native callback);

    public Promise<XRSession_End_delegate> End() {
        var value = XRSession_End(this.ID, XRSession_End_promise);
        return value == 0 ? null : new Promise<XRSession_End_delegate>(value, XRSession_End_promises);;
    }


    public EventHandler Onend {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "onend");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "onend", value==null ? 0 : value.ID);
        }
    }



    public EventHandler Oninputsourceschange {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "oninputsourceschange");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "oninputsourceschange", value==null ? 0 : value.ID);
        }
    }



    public EventHandler Onselect {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "onselect");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "onselect", value==null ? 0 : value.ID);
        }
    }



    public EventHandler Onselectstart {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "onselectstart");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "onselectstart", value==null ? 0 : value.ID);
        }
    }



    public EventHandler Onselectend {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "onselectend");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "onselectend", value==null ? 0 : value.ID);
        }
    }



    public EventHandler Onsqueeze {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "onsqueeze");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "onsqueeze", value==null ? 0 : value.ID);
        }
    }



    public EventHandler Onsqueezestart {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "onsqueezestart");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "onsqueezestart", value==null ? 0 : value.ID);
        }
    }



    public EventHandler Onsqueezeend {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "onsqueezeend");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "onsqueezeend", value==null ? 0 : value.ID);
        }
    }



    public EventHandler Onvisibilitychange {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "onvisibilitychange");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "onvisibilitychange", value==null ? 0 : value.ID);
        }
    }

}
