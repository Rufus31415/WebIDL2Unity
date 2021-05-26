
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRMediaLayerInit : WebIDL2UnityObject {


    internal XRMediaLayerInit (int id) : base(id) {}

    public XRMediaLayerInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRSpace Space {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "space");
            return value == 0 ? null : new XRSpace(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "space", value==null ? 0 : value.ID);
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



    public bool InvertStereo {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "invertStereo");
            return value;
        }
        set {
            WebIDL2Unity_boolean_set(this.ID, "invertStereo", value);
        }
    }

}
