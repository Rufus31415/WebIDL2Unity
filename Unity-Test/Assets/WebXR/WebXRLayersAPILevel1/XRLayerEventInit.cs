
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRLayerEventInit : EventInit {


    internal XRLayerEventInit (int id) : base(id) {}

    public XRLayerEventInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRLayer Layer {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "layer");
            return value == 0 ? null : new XRLayer(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "layer", value==null ? 0 : value.ID);
        }
    }

}
