
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRViewerPose : XRPose {


    internal XRViewerPose (int id) : base(id) {}


    public JSArray<XRView> Views {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "views");
            return new JSArray<XRView>(value);
        }
    }

}
