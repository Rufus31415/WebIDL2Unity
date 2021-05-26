
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XREquirectLayer : XRCompositionLayer {


    internal XREquirectLayer (int id) : base(id) {}


    public XRSpace Space {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "space");
            return value == 0 ? null : new XRSpace(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "space", value==null ? 0 : value.ID);
        }
    }



    public XRRigidTransform Transform {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "transform");
            return value == 0 ? null : new XRRigidTransform(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "transform", value==null ? 0 : value.ID);
        }
    }



    public float Radius {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "radius");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "radius", value);
        }
    }



    public float CentralHorizontalAngle {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "centralHorizontalAngle");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "centralHorizontalAngle", value);
        }
    }



    public float UpperVerticalAngle {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "upperVerticalAngle");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "upperVerticalAngle", value);
        }
    }



    public float LowerVerticalAngle {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "lowerVerticalAngle");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "lowerVerticalAngle", value);
        }
    }



    public EventHandler Onredraw {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "onredraw");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "onredraw", value==null ? 0 : value.ID);
        }
    }

}
