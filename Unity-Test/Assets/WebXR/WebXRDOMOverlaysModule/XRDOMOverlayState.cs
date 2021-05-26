
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRDOMOverlayState : WebIDL2UnityObject {


    internal XRDOMOverlayState (int id) : base(id) {}

    public XRDOMOverlayState() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRDOMOverlayType Type {
        get {
            var value = WebIDL2Unity_XRDOMOverlayType_get(this.ID, "type");
            return (XRDOMOverlayType)value;
        }
        set {
            WebIDL2Unity_XRDOMOverlayType_set(this.ID, "type", (int)value);
        }
    }

}
