
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRPose : WebIDL2UnityObject {


    internal XRPose (int id) : base(id) {}


    public XRRigidTransform Transform {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "transform");
            return value == 0 ? null : new XRRigidTransform(value);
        }
    }



    public DOMPointReadOnly LinearVelocity {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "linearVelocity");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }



    public DOMPointReadOnly AngularVelocity {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "angularVelocity");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }



    public bool EmulatedPosition {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "emulatedPosition");
            return value;
        }
    }

}
