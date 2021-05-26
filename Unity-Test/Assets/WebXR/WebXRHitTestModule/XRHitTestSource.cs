
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRHitTestSource : WebIDL2UnityObject {


    internal XRHitTestSource (int id) : base(id) {}


    [DllImport("__Internal")]
    private static extern int XRHitTestSource_Cancel(int id);

    public void Cancel() {
        XRHitTestSource_Cancel(this.ID);
        
    }
}
