
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRDOMOverlayInit : WebIDL2UnityObject {


    internal XRDOMOverlayInit (int id) : base(id) {}

    public XRDOMOverlayInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public Element Root {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "root");
            return value == 0 ? null : new Element(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "root", value==null ? 0 : value.ID);
        }
    }

}
