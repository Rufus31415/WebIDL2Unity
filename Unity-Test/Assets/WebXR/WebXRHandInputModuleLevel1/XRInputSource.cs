
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRInputSource : WebIDL2UnityObject {


    public XRHand Hand {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "hand");
            return value == 0 ? null : new XRHand(value);
        }
    }

}
