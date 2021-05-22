
using System;
using System.Runtime.InteropServices;

public  class XRReferenceSpace : WebIDL2UnityObject {


    internal XRReferenceSpace (int id) : base(id) {}



    public EventHandler Onreset {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "onreset");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "onreset", value.ID);
        }
    }

}
