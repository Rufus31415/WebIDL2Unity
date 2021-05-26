
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRProjectionLayer : XRCompositionLayer {


    internal XRProjectionLayer (int id) : base(id) {}


    public ulong TextureWidth {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "textureWidth");
            return value;
        }
    }



    public ulong TextureHeight {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "textureHeight");
            return value;
        }
    }



    public ulong TextureArrayLength {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "textureArrayLength");
            return value;
        }
    }



    public bool IgnoreDepthValues {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "ignoreDepthValues");
            return value;
        }
    }



    public float FixedFoveation {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "fixedFoveation");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "fixedFoveation", value);
        }
    }

}
