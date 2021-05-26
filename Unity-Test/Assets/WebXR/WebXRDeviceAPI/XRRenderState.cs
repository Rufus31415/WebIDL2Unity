
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRRenderState : WebIDL2UnityObject {


    internal XRRenderState (int id) : base(id) {}


    public double DepthNear {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "depthNear");
            return value;
        }
    }



    public double DepthFar {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "depthFar");
            return value;
        }
    }



    public double InlineVerticalFieldOfView {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "inlineVerticalFieldOfView");
            return value;
        }
    }



    public XRWebGLLayer BaseLayer {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "baseLayer");
            return value == 0 ? null : new XRWebGLLayer(value);
        }
    }

}
