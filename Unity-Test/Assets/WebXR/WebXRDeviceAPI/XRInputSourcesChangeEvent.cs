
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRInputSourcesChangeEvent : Event {


    internal XRInputSourcesChangeEvent (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRInputSourcesChangeEvent_2(string type, int eventInitDict);

    public XRInputSourcesChangeEvent(string type, XRInputSourcesChangeEventInit eventInitDict) : base(XRInputSourcesChangeEvent_2(type, eventInitDict==null ? 0 : eventInitDict.ID)) { }


    public XRSession Session {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "session");
            return value == 0 ? null : new XRSession(value);
        }
    }



    public JSArray<XRInputSource> Added {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "added");
            return new JSArray<XRInputSource>(value);
        }
    }



    public JSArray<XRInputSource> Removed {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "removed");
            return new JSArray<XRInputSource>(value);
        }
    }

}
