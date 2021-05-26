
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class WebGLContextAttributes : WebIDL2UnityObject {


    public bool XrCompatible {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "xrCompatible");
            return value;
        }
        set {
            WebIDL2Unity_boolean_set(this.ID, "xrCompatible", value);
        }
    }

}
