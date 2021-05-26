
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRView : WebIDL2UnityObject {


    internal XRView (int id) : base(id) {}


    public XREye Eye {
        get {
            var value = WebIDL2Unity_XREye_get(this.ID, "eye");
            return (XREye)value;
        }
    }



    public Float32Array ProjectionMatrix {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "projectionMatrix");
            return value == 0 ? null : new Float32Array(value);
        }
    }



    public XRRigidTransform Transform {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "transform");
            return value == 0 ? null : new XRRigidTransform(value);
        }
    }



    public double RecommendedViewportScale {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "recommendedViewportScale");
            return value;
        }
    }



    [DllImport("__Internal")]
    private static extern int XRView_RequestViewportScale(int id, double scale);

    public void RequestViewportScale(double scale) {
        XRView_RequestViewportScale(this.ID, scale);
        
    }
}
