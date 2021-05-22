
using System;
using System.Runtime.InteropServices;

public  class XRLayerEvent : WebIDL2UnityObject {


    internal XRLayerEvent (int id) : base(id) {}



    public XRLayer Layer {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "layer");
            return value == 0 ? null : new XRLayer(value);
        }
    }

}
