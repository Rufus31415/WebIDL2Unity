
using System;
using System.Runtime.InteropServices;

public  class XRLightProbe : WebIDL2UnityObject {


    internal XRLightProbe (int id) : base(id) {}


    public XRSpace ProbeSpace {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "probeSpace");
            return value == 0 ? null : new XRSpace(value);
        }
    }



    public EventHandler Onreflectionchange {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "onreflectionchange");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "onreflectionchange", value.ID);
        }
    }

}
