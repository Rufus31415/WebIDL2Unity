
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRRigidTransform : WebIDL2UnityObject {


    internal XRRigidTransform (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRRigidTransform_2(int position, int orientation);

    public XRRigidTransform(DOMPointInit position, DOMPointInit orientation) : base(XRRigidTransform_2(position==null ? 0 : position.ID, orientation==null ? 0 : orientation.ID)) { }


    public DOMPointReadOnly Position {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "position");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }



    public DOMPointReadOnly Orientation {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "orientation");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }



    public Float32Array Matrix {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "matrix");
            return value == 0 ? null : new Float32Array(value);
        }
    }



    public XRRigidTransform Inverse {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "inverse");
            return value == 0 ? null : new XRRigidTransform(value);
        }
    }

}
