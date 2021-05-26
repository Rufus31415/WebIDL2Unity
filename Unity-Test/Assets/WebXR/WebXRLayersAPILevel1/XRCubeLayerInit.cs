
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRCubeLayerInit : XRLayerInit {


    internal XRCubeLayerInit (int id) : base(id) {}

    public XRCubeLayerInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public DOMPointReadOnly Orientation {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "orientation");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "orientation", value==null ? 0 : value.ID);
        }
    }

}
