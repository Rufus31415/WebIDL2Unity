
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRInputSourceEvent : Event {


    internal XRInputSourceEvent (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRInputSourceEvent_2(string type, int eventInitDict);

    public XRInputSourceEvent(string type, XRInputSourceEventInit eventInitDict) : base(XRInputSourceEvent_2(type, eventInitDict==null ? 0 : eventInitDict.ID)) { }


    public XRFrame Frame {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "frame");
            return value == 0 ? null : new XRFrame(value);
        }
    }



    public XRInputSource InputSource {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "inputSource");
            return value == 0 ? null : new XRInputSource(value);
        }
    }

}
