
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRFrame : WebIDL2UnityObject {


    [DllImport("__Internal")]
    private static extern int XRFrame_GetHitTestResults(int id, int hitTestSource);

    public JSArray<XRHitTestResult> GetHitTestResults(XRHitTestSource hitTestSource) {
        var value = XRFrame_GetHitTestResults(this.ID, hitTestSource==null ? 0 : hitTestSource.ID);
        return new JSArray<XRHitTestResult>(value);
    }


    [DllImport("__Internal")]
    private static extern int XRFrame_GetHitTestResultsForTransientInput(int id, int hitTestSource);

    public JSArray<XRTransientInputHitTestResult> GetHitTestResultsForTransientInput(XRTransientInputHitTestSource hitTestSource) {
        var value = XRFrame_GetHitTestResultsForTransientInput(this.ID, hitTestSource==null ? 0 : hitTestSource.ID);
        return new JSArray<XRTransientInputHitTestResult>(value);
    }
}
