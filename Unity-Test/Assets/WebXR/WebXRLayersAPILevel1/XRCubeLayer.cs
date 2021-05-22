
using System;
using System.Runtime.InteropServices;

public  class XRCubeLayer : WebIDL2UnityObject {


    internal XRCubeLayer (int id) : base(id) {}


    public XRSpace Space {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "space");
            return value == 0 ? null : new XRSpace(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "space", value.ID);
        }
    }



    public DOMPointReadOnly Orientation {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "orientation");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "orientation", value.ID);
        }
    }



    public EventHandler Onredraw {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "onredraw");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "onredraw", value.ID);
        }
    }

}
