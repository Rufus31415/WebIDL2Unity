
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRRay : WebIDL2UnityObject {


    internal XRRay (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRRay_2(int origin, int direction);

    public XRRay(DOMPointInit origin, XRRayDirectionInit direction) : base(XRRay_2(origin==null ? 0 : origin.ID, direction==null ? 0 : direction.ID)) { }


    [DllImport("__Internal")]
    private static extern int XRRay_1(int transform);

    public XRRay(XRRigidTransform transform) : base(XRRay_1(transform==null ? 0 : transform.ID)) { }


    public DOMPointReadOnly Origin {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "origin");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }



    public DOMPointReadOnly Direction {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "direction");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }



    public Float32Array Matrix {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "matrix");
            return value == 0 ? null : new Float32Array(value);
        }
    }

}
