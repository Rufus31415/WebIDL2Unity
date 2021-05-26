
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRCylinderLayer : XRCompositionLayer {


    internal XRCylinderLayer (int id) : base(id) {}


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



    public float CentralAngle {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "centralAngle");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "centralAngle", value);
        }
    }



    public float AspectRatio {
        get {
            var value = WebIDL2Unity_float_get(this.ID, "aspectRatio");
            return value;
        }
        set {
            WebIDL2Unity_float_set(this.ID, "aspectRatio", value);
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
