
using System;
using System.Runtime.InteropServices;

public partial  class XRFrame : WebIDL2UnityObject {



    public XRAnchorSet TrackedAnchors {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "trackedAnchors");
            return value == 0 ? null : new XRAnchorSet(value);
        }
    }

}
