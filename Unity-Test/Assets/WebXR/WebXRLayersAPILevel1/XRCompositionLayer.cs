
using System;
using System.Runtime.InteropServices;

public  class XRCompositionLayer : WebIDL2UnityObject {


    internal XRCompositionLayer (int id) : base(id) {}


    public XRLayerLayout Layout {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "layout");
            return (XRLayerLayout)value;
        }
    }



    public bool BlendTextureSourceAlpha {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "blendTextureSourceAlpha");
            return value;
        }
        set {
            WebIDL2Unity_boolean_set(this.ID, "blendTextureSourceAlpha", value);
        }
    }



    public bool ChromaticAberrationCorrection {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "chromaticAberrationCorrection");
            return value;
        }
        set {
            WebIDL2Unity_boolean_set(this.ID, "chromaticAberrationCorrection", value);
        }
    }



    public ulong MipLevels {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "mipLevels");
            return value;
        }
    }



    public bool NeedsRedraw {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "needsRedraw");
            return value;
        }
    }


}
