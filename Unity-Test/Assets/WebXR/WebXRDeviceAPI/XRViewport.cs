
using System;
using System.Runtime.InteropServices;

public  class XRViewport : WebIDL2UnityObject {


    internal XRViewport (int id) : base(id) {}


    public long X {
        get {
            var value = WebIDL2Unity_long_get(this.ID, "x");
            return value;
        }
    }



    public long Y {
        get {
            var value = WebIDL2Unity_long_get(this.ID, "y");
            return value;
        }
    }



    public long Width {
        get {
            var value = WebIDL2Unity_long_get(this.ID, "width");
            return value;
        }
    }



    public long Height {
        get {
            var value = WebIDL2Unity_long_get(this.ID, "height");
            return value;
        }
    }

}
