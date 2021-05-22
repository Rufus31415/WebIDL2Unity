
using System;
using System.Runtime.InteropServices;

public  class XRSessionEventInit : WebIDL2UnityObject {


    internal XRSessionEventInit (int id) : base(id) {}

    public XRSessionEventInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRSession Session {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "session");
            return value == 0 ? null : new XRSession(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "session", value.ID);
        }
    }

}
