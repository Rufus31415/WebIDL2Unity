
using System;
using System.Runtime.InteropServices;

public  class XRSessionEvent : WebIDL2UnityObject {


    internal XRSessionEvent (int id) : base(id) {}



    public XRSession Session {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "session");
            return value == 0 ? null : new XRSession(value);
        }
    }

}
