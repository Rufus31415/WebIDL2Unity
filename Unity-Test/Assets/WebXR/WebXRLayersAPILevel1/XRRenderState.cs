
using System;
using System.Runtime.InteropServices;

public partial  class XRRenderState : WebIDL2UnityObject {


    public FrozenArray<XRLayer> Layers {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "layers");
            return new FrozenArray<XRLayer>(value);
        }
    }

}
