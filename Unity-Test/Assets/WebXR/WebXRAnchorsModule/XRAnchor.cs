
using System;
using System.Runtime.InteropServices;

public  class XRAnchor : WebIDL2UnityObject {


    internal XRAnchor (int id) : base(id) {}


    public XRSpace AnchorSpace {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "anchorSpace");
            return value == 0 ? null : new XRSpace(value);
        }
    }


}
