
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRLayerEvent : Event {


    internal XRLayerEvent (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRLayerEvent_2(string type, int eventInitDict);

    public XRLayerEvent(string type, XRLayerEventInit eventInitDict) : base(XRLayerEvent_2(type, eventInitDict==null ? 0 : eventInitDict.ID)) { }


    public XRLayer Layer {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "layer");
            return value == 0 ? null : new XRLayer(value);
        }
    }

}
