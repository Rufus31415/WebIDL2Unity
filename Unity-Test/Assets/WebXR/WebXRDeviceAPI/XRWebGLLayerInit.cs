
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRWebGLLayerInit : WebIDL2UnityObject {


    internal XRWebGLLayerInit (int id) : base(id) {}

    public XRWebGLLayerInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public bool Antialias {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "antialias");
            return value;
        }
        set {
            WebIDL2Unity_boolean_set(this.ID, "antialias", value);
        }
    }



    public bool Depth {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "depth");
            return value;
        }
        set {
            WebIDL2Unity_boolean_set(this.ID, "depth", value);
        }
    }



    public bool Stencil {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "stencil");
            return value;
        }
        set {
            WebIDL2Unity_boolean_set(this.ID, "stencil", value);
        }
    }



    public bool Alpha {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "alpha");
            return value;
        }
        set {
            WebIDL2Unity_boolean_set(this.ID, "alpha", value);
        }
    }



    public bool IgnoreDepthValues {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "ignoreDepthValues");
            return value;
        }
        set {
            WebIDL2Unity_boolean_set(this.ID, "ignoreDepthValues", value);
        }
    }



    public double FramebufferScaleFactor {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "framebufferScaleFactor");
            return value;
        }
        set {
            WebIDL2Unity_double_set(this.ID, "framebufferScaleFactor", value);
        }
    }

}
