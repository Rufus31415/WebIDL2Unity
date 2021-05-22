
using System;
using System.Runtime.InteropServices;

public  class XREquirectLayerInit : WebIDL2UnityObject {


    internal XREquirectLayerInit (int id) : base(id) {}

    public XREquirectLayerInit() : base(WebIDL2UnityGetNewDictionnary()) { }


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



    public float CentralHorizontalAngle {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "centralHorizontalAngle");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "centralHorizontalAngle", value);
        }
    }



    public float UpperVerticalAngle {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "upperVerticalAngle");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "upperVerticalAngle", value);
        }
    }



    public float LowerVerticalAngle {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "lowerVerticalAngle");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "lowerVerticalAngle", value);
        }
    }

}
