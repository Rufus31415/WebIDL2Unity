
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRLightProbe : EventTarget {


    internal XRLightProbe (int id) : base(id) {}


    public XRSpace ProbeSpace {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "probeSpace");
            return value == 0 ? null : new XRSpace(value);
        }
    }



    public EventHandler Onreflectionchange {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "onreflectionchange");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "onreflectionchange", value==null ? 0 : value.ID);
        }
    }

}
