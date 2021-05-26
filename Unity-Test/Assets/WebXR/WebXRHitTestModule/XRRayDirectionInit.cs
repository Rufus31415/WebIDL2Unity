
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRRayDirectionInit : WebIDL2UnityObject {


    internal XRRayDirectionInit (int id) : base(id) {}

    public XRRayDirectionInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public double X {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "x");
            return value;
        }
        set {
            WebIDL2Unity_double_set(this.ID, "x", value);
        }
    }



    public double Y {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "y");
            return value;
        }
        set {
            WebIDL2Unity_double_set(this.ID, "y", value);
        }
    }



    public double Z {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "z");
            return value;
        }
        set {
            WebIDL2Unity_double_set(this.ID, "z", value);
        }
    }



    public double W {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "w");
            return value;
        }
        set {
            WebIDL2Unity_double_set(this.ID, "w", value);
        }
    }

}
