
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRMediaCylinderLayerInit : XRMediaLayerInit {


    internal XRMediaCylinderLayerInit (int id) : base(id) {}

    public XRMediaCylinderLayerInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRRigidTransform Transform {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "transform");
            return value == 0 ? null : new XRRigidTransform(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "transform", value==null ? 0 : value.ID);
        }
    }



    public float Radius {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "radius");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "radius", value);
        }
    }



    public float CentralAngle {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "centralAngle");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "centralAngle", value);
        }
    }



    public float AspectRatio {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "aspectRatio");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "aspectRatio", value);
        }
    }

}
