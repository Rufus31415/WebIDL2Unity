
using System;
using System.Runtime.InteropServices;

public partial  class XRSession : WebIDL2UnityObject {


    public XRDOMOverlayState DomOverlayState {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "domOverlayState");
            return value == 0 ? null : new XRDOMOverlayState(value);
        }
    }

}
