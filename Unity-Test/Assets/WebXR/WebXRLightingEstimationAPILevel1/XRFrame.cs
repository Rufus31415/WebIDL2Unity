
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRFrame : WebIDL2UnityObject {


    [DllImport("__Internal")]
    private static extern int XRFrame_GetLightEstimate(int id, int lightProbe);

    public XRLightEstimate GetLightEstimate(XRLightProbe lightProbe) {
        var value = XRFrame_GetLightEstimate(this.ID, lightProbe==null ? 0 : lightProbe.ID);
        return value == 0 ? null : new XRLightEstimate(value);
    }
}
