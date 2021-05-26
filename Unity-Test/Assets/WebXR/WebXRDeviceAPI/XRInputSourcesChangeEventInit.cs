
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRInputSourcesChangeEventInit : EventInit {


    internal XRInputSourcesChangeEventInit (int id) : base(id) {}

    public XRInputSourcesChangeEventInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRSession Session {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "session");
            return value == 0 ? null : new XRSession(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "session", value==null ? 0 : value.ID);
        }
    }



    public JSArray<XRInputSource> Added {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "added");
            return new JSArray<XRInputSource>(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "added", value==null ? 0 : value.ID);
        }
    }



    public JSArray<XRInputSource> Removed {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "removed");
            return new JSArray<XRInputSource>(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "removed", value==null ? 0 : value.ID);
        }
    }

}
