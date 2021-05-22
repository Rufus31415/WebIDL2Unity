
using System;
using System.Runtime.InteropServices;

public  class XRMediaQuadLayerInit : WebIDL2UnityObject {


    internal XRMediaQuadLayerInit (int id) : base(id) {}

    public XRMediaQuadLayerInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRRigidTransform Transform {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "transform");
            return value == 0 ? null : new XRRigidTransform(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "transform", value.ID);
        }
    }



    public float Width {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "width");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "width", value);
        }
    }



    public float Height {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "height");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "height", value);
        }
    }

}
