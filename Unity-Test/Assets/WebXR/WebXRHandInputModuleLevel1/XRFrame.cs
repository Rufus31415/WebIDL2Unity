
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRFrame : WebIDL2UnityObject {


    [DllImport("__Internal")]
    private static extern int XRFrame_GetJointPose(int id, int joint, int baseSpace);

    public XRJointPose GetJointPose(XRJointSpace joint, XRSpace baseSpace) {
        var value = XRFrame_GetJointPose(this.ID, joint==null ? 0 : joint.ID, baseSpace==null ? 0 : baseSpace.ID);
        return value == 0 ? null : new XRJointPose(value);
    }


    [DllImport("__Internal")]
    private static extern bool XRFrame_FillJointRadii(int id, int jointSpaces, int radii);

    public bool FillJointRadii(FrozenArray<XRJointSpace> jointSpaces, Float32Array radii) {
        var value = XRFrame_FillJointRadii(this.ID, jointSpaces==null ? 0 : jointSpaces.ID, radii==null ? 0 : radii.ID);
        return value;
    }


    [DllImport("__Internal")]
    private static extern bool XRFrame_FillPoses(int id, int spaces, int baseSpace, int transforms);

    public bool FillPoses(FrozenArray<XRSpace> spaces, XRSpace baseSpace, Float32Array transforms) {
        var value = XRFrame_FillPoses(this.ID, spaces==null ? 0 : spaces.ID, baseSpace==null ? 0 : baseSpace.ID, transforms==null ? 0 : transforms.ID);
        return value;
    }
}
