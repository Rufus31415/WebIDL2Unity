
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRWebGLSubImage : XRSubImage {


    internal XRWebGLSubImage (int id) : base(id) {}


    public WebGLTexture ColorTexture {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "colorTexture");
            return value == 0 ? null : new WebGLTexture(value);
        }
    }



    public WebGLTexture DepthStencilTexture {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "depthStencilTexture");
            return value == 0 ? null : new WebGLTexture(value);
        }
    }



    public ulong ImageIndex {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "imageIndex");
            return value;
        }
    }



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

}
