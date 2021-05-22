
using System;
using System.Runtime.InteropServices;

public  class XRLayerEventInit : WebIDL2UnityObject {


    internal XRLayerEventInit (int id) : base(id) {}

    public XRLayerEventInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRLayer Layer {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "layer");
            return value == 0 ? null : new XRLayer(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "layer", value.ID);
        }
    }

}
