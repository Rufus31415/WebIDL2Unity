
using System;
using System.Runtime.InteropServices;

public  class XRJointSpace : WebIDL2UnityObject {


    internal XRJointSpace (int id) : base(id) {}


    public XRHandJoint JointName {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "jointName");
            return (XRHandJoint)value;
        }
    }

}
