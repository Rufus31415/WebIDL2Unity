
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRWebGLLayer : XRLayer {


    internal XRWebGLLayer (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRWebGLLayer_3(int session, int context, int layerInit);

    public XRWebGLLayer(XRSession session, XRWebGLRenderingContext context, XRWebGLLayerInit layerInit) : base(XRWebGLLayer_3(session==null ? 0 : session.ID, context==null ? 0 : context.ID, layerInit==null ? 0 : layerInit.ID)) { }


    public bool Antialias {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "antialias");
            return value;
        }
    }



    public bool IgnoreDepthValues {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "ignoreDepthValues");
            return value;
        }
    }



    public WebGLFramebuffer Framebuffer {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "framebuffer");
            return value == 0 ? null : new WebGLFramebuffer(value);
        }
    }



    public ulong FramebufferWidth {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "framebufferWidth");
            return value;
        }
    }



    public ulong FramebufferHeight {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "framebufferHeight");
            return value;
        }
    }



    [DllImport("__Internal")]
    private static extern int XRWebGLLayer_GetViewport(int id, int view);

    public XRViewport GetViewport(XRView view) {
        var value = XRWebGLLayer_GetViewport(this.ID, view==null ? 0 : view.ID);
        return value == 0 ? null : new XRViewport(value);
    }


    [DllImport("__Internal")]
    private static extern double XRWebGLLayer_GetNativeFramebufferScaleFactor(int id, int session);

    public double GetNativeFramebufferScaleFactor(XRSession session) {
        var value = XRWebGLLayer_GetNativeFramebufferScaleFactor(this.ID, session==null ? 0 : session.ID);
        return value;
    }
}
