
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRSessionEventInit : EventInit {


    internal XRSessionEventInit (int id) : base(id) {}

    public XRSessionEventInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRSession Session {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "session");
            return value == 0 ? null : new XRSession(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "session", value==null ? 0 : value.ID);
        }
    }

}
