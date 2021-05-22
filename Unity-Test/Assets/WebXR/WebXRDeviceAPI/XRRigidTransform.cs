
using System;
using System.Runtime.InteropServices;

public  class XRRigidTransform : WebIDL2UnityObject {


    internal XRRigidTransform (int id) : base(id) {}



    public DOMPointReadOnly Position {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "position");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }



    public DOMPointReadOnly Orientation {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "orientation");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }



    public FrozenArray<float> Matrix {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "matrix");
            return new FrozenArray<float>(value);
        }
    }



    public XRRigidTransform Inverse {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "inverse");
            return value == 0 ? null : new XRRigidTransform(value);
        }
    }

}
