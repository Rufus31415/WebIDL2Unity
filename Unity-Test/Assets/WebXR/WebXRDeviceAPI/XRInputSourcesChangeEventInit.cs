
using System;
using System.Runtime.InteropServices;

public  class XRInputSourcesChangeEventInit : WebIDL2UnityObject {


    internal XRInputSourcesChangeEventInit (int id) : base(id) {}

    public XRInputSourcesChangeEventInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRSession Session {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "session");
            return value == 0 ? null : new XRSession(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "session", value.ID);
        }
    }



    public FrozenArray<XRInputSource> Added {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "added");
            return new FrozenArray<XRInputSource>(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "added", value.ID);
        }
    }



    public FrozenArray<XRInputSource> Removed {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "removed");
            return new FrozenArray<XRInputSource>(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "removed", value.ID);
        }
    }

}
