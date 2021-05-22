
using System;
using System.Runtime.InteropServices;

public  class XRSystem : WebIDL2UnityObject {


    internal XRSystem (int id) : base(id) {}




    public EventHandler Ondevicechange {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "ondevicechange");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "ondevicechange", value.ID);
        }
    }

}
