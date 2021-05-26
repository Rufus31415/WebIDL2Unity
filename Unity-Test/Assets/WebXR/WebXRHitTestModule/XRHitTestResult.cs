
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRHitTestResult : WebIDL2UnityObject {


    internal XRHitTestResult (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRHitTestResult_GetPose(int id, int baseSpace);

    public XRPose GetPose(XRSpace baseSpace) {
        var value = XRHitTestResult_GetPose(this.ID, baseSpace==null ? 0 : baseSpace.ID);
        return value == 0 ? null : new XRPose(value);
    }
}
