
using System;
using System.Runtime.InteropServices;

public  class XRJointPose : WebIDL2UnityObject {


    internal XRJointPose (int id) : base(id) {}


    public float Radius {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "radius");
            return value;
        }
    }

}
