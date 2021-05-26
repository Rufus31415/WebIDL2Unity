
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRSessionInit : WebIDL2UnityObject {


    public XRDOMOverlayInit DomOverlay {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "domOverlay");
            return value == 0 ? null : new XRDOMOverlayInit(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "domOverlay", value==null ? 0 : value.ID);
        }
    }

}
