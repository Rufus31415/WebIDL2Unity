
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRRenderStateInit : WebIDL2UnityObject {


    internal XRRenderStateInit (int id) : base(id) {}

    public XRRenderStateInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public double DepthNear {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "depthNear");
            return value;
        }
        set {
            WebIDL2Unity_double_set(this.ID, "depthNear", value);
        }
    }



    public double DepthFar {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "depthFar");
            return value;
        }
        set {
            WebIDL2Unity_double_set(this.ID, "depthFar", value);
        }
    }



    public double InlineVerticalFieldOfView {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "inlineVerticalFieldOfView");
            return value;
        }
        set {
            WebIDL2Unity_double_set(this.ID, "inlineVerticalFieldOfView", value);
        }
    }



    public XRWebGLLayer BaseLayer {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "baseLayer");
            return value == 0 ? null : new XRWebGLLayer(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "baseLayer", value==null ? 0 : value.ID);
        }
    }



    public FrozenArray<XRLayer> Layers {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "layers");
            return new JSArray<XRLayer>(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "layers", value==null ? 0 : value.ID);
        }
    }

}
