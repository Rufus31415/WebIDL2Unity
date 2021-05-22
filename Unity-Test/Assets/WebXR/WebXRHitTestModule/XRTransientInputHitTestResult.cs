
using System;
using System.Runtime.InteropServices;

public  class XRTransientInputHitTestResult : WebIDL2UnityObject {


    internal XRTransientInputHitTestResult (int id) : base(id) {}


    public XRInputSource InputSource {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "inputSource");
            return value == 0 ? null : new XRInputSource(value);
        }
    }



    public FrozenArray<XRHitTestResult> Results {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "results");
            return new FrozenArray<XRHitTestResult>(value);
        }
    }

}
