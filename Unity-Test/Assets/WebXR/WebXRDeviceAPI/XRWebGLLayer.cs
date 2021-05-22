
using System;
using System.Runtime.InteropServices;

public  class XRWebGLLayer : WebIDL2UnityObject {


    internal XRWebGLLayer (int id) : base(id) {}



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
            var value = WebIDL2Unity_short_get(this.ID, "framebuffer");
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



}
