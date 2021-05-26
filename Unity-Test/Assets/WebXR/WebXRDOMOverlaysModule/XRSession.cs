
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRSession : EventTarget {


    public XRDOMOverlayState DomOverlayState {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "domOverlayState");
            return value == 0 ? null : new XRDOMOverlayState(value);
        }
    }

}
