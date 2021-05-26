
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRBoundedReferenceSpace : XRReferenceSpace {


    internal XRBoundedReferenceSpace (int id) : base(id) {}


    public JSArray<DOMPointReadOnly> BoundsGeometry {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "boundsGeometry");
            return new JSArray<DOMPointReadOnly>(value);
        }
    }

}
