
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRRenderState : WebIDL2UnityObject {


    public JSArray<XRLayer> Layers {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "layers");
            return new JSArray<XRLayer>(value);
        }
    }

}
