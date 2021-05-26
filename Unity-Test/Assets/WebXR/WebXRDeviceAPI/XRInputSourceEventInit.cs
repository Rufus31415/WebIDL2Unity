
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRInputSourceEventInit : EventInit {


    internal XRInputSourceEventInit (int id) : base(id) {}

    public XRInputSourceEventInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRFrame Frame {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "frame");
            return value == 0 ? null : new XRFrame(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "frame", value==null ? 0 : value.ID);
        }
    }



    public XRInputSource InputSource {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "inputSource");
            return value == 0 ? null : new XRInputSource(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "inputSource", value==null ? 0 : value.ID);
        }
    }

}
