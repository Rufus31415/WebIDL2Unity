
using System;
using System.Runtime.InteropServices;

public partial  class XRView : WebIDL2UnityObject {


    public bool IsFirstPersonObserver {
        get {
            var value = WebIDL2Unity_boolean_get(this.ID, "isFirstPersonObserver");
            return value;
        }
    }

}
