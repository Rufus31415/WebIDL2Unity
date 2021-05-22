
using System;
using System.Runtime.InteropServices;

public  class XRCubeLayerInit : WebIDL2UnityObject {


    internal XRCubeLayerInit (int id) : base(id) {}

    public XRCubeLayerInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public DOMPointReadOnly Orientation {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "orientation");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "orientation", value.ID);
        }
    }

}
