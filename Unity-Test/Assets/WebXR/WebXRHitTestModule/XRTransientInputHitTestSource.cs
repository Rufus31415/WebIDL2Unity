
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRTransientInputHitTestSource : WebIDL2UnityObject {


    internal XRTransientInputHitTestSource (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRTransientInputHitTestSource_Cancel(int id);

    public void Cancel() {
        XRTransientInputHitTestSource_Cancel(this.ID);
        
    }
}
