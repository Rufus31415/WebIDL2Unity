
using System;
using System.Runtime.InteropServices;

public  class XRRay : WebIDL2UnityObject {


    internal XRRay (int id) : base(id) {}




    public DOMPointReadOnly Origin {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "origin");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }



    public DOMPointReadOnly Direction {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "direction");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }



    public FrozenArray<float> Matrix {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "matrix");
            return new FrozenArray<float>(value);
        }
    }

}
