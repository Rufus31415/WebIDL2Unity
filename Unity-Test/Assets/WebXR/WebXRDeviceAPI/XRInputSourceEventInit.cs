
using System;
using System.Runtime.InteropServices;

public  class XRInputSourceEventInit : WebIDL2UnityObject {


    internal XRInputSourceEventInit (int id) : base(id) {}

    public XRInputSourceEventInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRFrame Frame {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "frame");
            return value == 0 ? null : new XRFrame(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "frame", value.ID);
        }
    }



    public XRInputSource InputSource {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "inputSource");
            return value == 0 ? null : new XRInputSource(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "inputSource", value.ID);
        }
    }

}
