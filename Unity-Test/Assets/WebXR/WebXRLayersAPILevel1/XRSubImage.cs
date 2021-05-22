
using System;
using System.Runtime.InteropServices;

public  class XRSubImage : WebIDL2UnityObject {


    internal XRSubImage (int id) : base(id) {}


    public XRViewport Viewport {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "viewport");
            return value == 0 ? null : new XRViewport(value);
        }
    }

}
