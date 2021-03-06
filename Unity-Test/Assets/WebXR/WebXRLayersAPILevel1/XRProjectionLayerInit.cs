
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRProjectionLayerInit : WebIDL2UnityObject {


    internal XRProjectionLayerInit (int id) : base(id) {}

    public XRProjectionLayerInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRTextureType TextureType {
        get {
            var value = WebIDL2Unity_XRTextureType_get(this.ID, "textureType");
            return (XRTextureType)value;
        }
        set {
            WebIDL2Unity_XRTextureType_set(this.ID, "textureType", (int)value);
        }
    }



    public GLenum ColorFormat {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "colorFormat");
            return value == 0 ? null : new GLenum(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "colorFormat", value==null ? 0 : value.ID);
        }
    }



    public GLenum DepthFormat {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "depthFormat");
            return value == 0 ? null : new GLenum(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "depthFormat", value==null ? 0 : value.ID);
        }
    }



    public double ScaleFactor {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "scaleFactor");
            return value;
        }
        set {
            WebIDL2Unity_double_set(this.ID, "scaleFactor", value);
        }
    }

}
