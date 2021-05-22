
using System;
using System.Runtime.InteropServices;

public  class XRBoundedReferenceSpace : WebIDL2UnityObject {


    internal XRBoundedReferenceSpace (int id) : base(id) {}


    public FrozenArray<DOMPointReadOnly> BoundsGeometry {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "boundsGeometry");
            return new FrozenArray<DOMPointReadOnly>(value);
        }
    }

}
