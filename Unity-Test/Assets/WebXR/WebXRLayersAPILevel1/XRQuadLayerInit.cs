
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRQuadLayerInit : XRLayerInit {


    internal XRQuadLayerInit (int id) : base(id) {}

    public XRQuadLayerInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRTextureType TextureType {
        get {
            var value = WebIDL2Unity_XRTextureType_get(this.ID, "textureType");
            return (XRTextureType)value;
        }
        set {
            WebIDL2Unity_XRTextureType_set(this.ID, "textureType", (int)value);
        }
    }



    public XRRigidTransform Transform {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "transform");
            return value == 0 ? null : new XRRigidTransform(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "transform", value==null ? 0 : value.ID);
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
