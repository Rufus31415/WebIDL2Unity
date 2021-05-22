
using System;
using System.Runtime.InteropServices;

public partial  class XRView : WebIDL2UnityObject {


    internal XRView (int id) : base(id) {}


    public XREye Eye {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "eye");
            return (XREye)value;
        }
    }



    public FrozenArray<float> ProjectionMatrix {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "projectionMatrix");
            return new FrozenArray<float>(value);
        }
    }



    public XRRigidTransform Transform {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "transform");
            return value == 0 ? null : new XRRigidTransform(value);
        }
    }



    public double RecommendedViewportScale {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "recommendedViewportScale");
            return value;
        }
    }


}
