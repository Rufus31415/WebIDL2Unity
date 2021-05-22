
using System;
using System.Runtime.InteropServices;

public  class XRCylinderLayerInit : WebIDL2UnityObject {


    internal XRCylinderLayerInit (int id) : base(id) {}

    public XRCylinderLayerInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRTextureType TextureType {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "textureType");
            return (XRTextureType)value;
        }
        set {
            WebIDL2Unity_short_set(this.ID, "textureType", (int)value);
        }
    }



    public XRRigidTransform Transform {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "transform");
            return value == 0 ? null : new XRRigidTransform(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "transform", value.ID);
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
