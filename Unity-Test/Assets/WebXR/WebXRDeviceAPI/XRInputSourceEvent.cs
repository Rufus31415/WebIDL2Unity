
using System;
using System.Runtime.InteropServices;

public  class XRInputSourceEvent : WebIDL2UnityObject {


    internal XRInputSourceEvent (int id) : base(id) {}



    public XRFrame Frame {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "frame");
            return value == 0 ? null : new XRFrame(value);
        }
    }



    public XRInputSource InputSource {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "inputSource");
            return value == 0 ? null : new XRInputSource(value);
        }
    }

}
