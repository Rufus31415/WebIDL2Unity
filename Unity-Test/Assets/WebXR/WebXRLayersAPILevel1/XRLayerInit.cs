
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRLayerInit : WebIDL2UnityObject {


    internal XRLayerInit (int id) : base(id) {}

    public XRLayerInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRSpace Space {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "space");
            return value == 0 ? null : new XRSpace(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "space", value==null ? 0 : value.ID);
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



    public ulong MipLevels {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "mipLevels");
            return value;
        }
        set {
            WebIDL2Unity_unsigned_long_set(this.ID, "mipLevels", value);
        }
    }



    public ulong ViewPixelWidth {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "viewPixelWidth");
            return value;
        }
        set {
            WebIDL2Unity_unsigned_long_set(this.ID, "viewPixelWidth", value);
        }
    }



    public ulong ViewPixelHeight {
        get {
            var value = WebIDL2Unity_unsigned_long_get(this.ID, "viewPixelHeight");
            return value;
        }
        set {
            WebIDL2Unity_unsigned_long_set(this.ID, "viewPixelHeight", value);
        }
    }



    public XRLayerLayout Layout {
        get {
            var value = WebIDL2Unity_XRLayerLayout_get(this.ID, "layout");
            return (XRLayerLayout)value;
        }
        set {
            WebIDL2Unity_XRLayerLayout_set(this.ID, "layout", (int)value);
        }
    }



    public bool IsStatic {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "isStatic");
            return value;
        }
        set {
            WebIDL2Unity_boolean_set(this.ID, "isStatic", value);
        }
    }

}
