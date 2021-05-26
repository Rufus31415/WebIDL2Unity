
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRSessionEvent : Event {


    internal XRSessionEvent (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRSessionEvent_2(string type, int eventInitDict);

    public XRSessionEvent(string type, XRSessionEventInit eventInitDict) : base(XRSessionEvent_2(type, eventInitDict==null ? 0 : eventInitDict.ID)) { }


    public XRSession Session {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "session");
            return value == 0 ? null : new XRSession(value);
        }
    }

}
