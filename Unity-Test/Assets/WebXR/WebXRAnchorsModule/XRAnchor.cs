
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRAnchor : WebIDL2UnityObject {


    internal XRAnchor (int id) : base(id) {}


    public XRSpace AnchorSpace {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "anchorSpace");
            return value == 0 ? null : new XRSpace(value);
        }
    }



    [DllImport("__Internal")]
    private static extern int XRAnchor_Delete(int id);

    public void Delete() {
        XRAnchor_Delete(this.ID);
        
    }
}
