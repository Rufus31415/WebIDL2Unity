
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRCompositionLayer : XRLayer {


    internal XRCompositionLayer (int id) : base(id) {}


    public XRLayerLayout Layout {
        get {
            var value = WebIDL2Unity_XRLayerLayout_get(this.ID, "layout");
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



    [DllImport("__Internal")]
    private static extern int XRCompositionLayer_Destroy(int id);

    public void Destroy() {
        XRCompositionLayer_Destroy(this.ID);
        
    }
}
