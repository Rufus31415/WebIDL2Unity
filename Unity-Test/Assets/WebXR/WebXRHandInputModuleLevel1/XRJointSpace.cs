
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRJointSpace : XRSpace {


    internal XRJointSpace (int id) : base(id) {}


    public XRHandJoint JointName {
        get {
            var value = WebIDL2Unity_XRHandJoint_get(this.ID, "jointName");
            return (XRHandJoint)value;
        }
    }

}
