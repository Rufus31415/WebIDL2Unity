
using System;
using System.Runtime.InteropServices;

public  class XRViewerPose : WebIDL2UnityObject {


    internal XRViewerPose (int id) : base(id) {}


    public FrozenArray<XRView> Views {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "views");
            return new FrozenArray<XRView>(value);
        }
    }

}
