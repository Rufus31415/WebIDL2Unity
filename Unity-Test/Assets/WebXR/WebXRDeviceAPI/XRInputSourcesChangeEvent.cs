
using System;
using System.Runtime.InteropServices;

public  class XRInputSourcesChangeEvent : WebIDL2UnityObject {


    internal XRInputSourcesChangeEvent (int id) : base(id) {}



    public XRSession Session {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "session");
            return value == 0 ? null : new XRSession(value);
        }
    }



    public FrozenArray<XRInputSource> Added {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "added");
            return new FrozenArray<XRInputSource>(value);
        }
    }



    public FrozenArray<XRInputSource> Removed {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "removed");
            return new FrozenArray<XRInputSource>(value);
        }
    }

}
