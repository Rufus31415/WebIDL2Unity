
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRInputSource : WebIDL2UnityObject {


    public Gamepad Gamepad {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "gamepad");
            return value == 0 ? null : new Gamepad(value);
        }
    }

}
