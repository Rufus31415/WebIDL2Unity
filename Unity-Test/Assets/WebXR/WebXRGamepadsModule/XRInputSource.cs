
using System;
using System.Runtime.InteropServices;

public partial  class XRInputSource : WebIDL2UnityObject {


    public Gamepad Gamepad {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "gamepad");
            return value == 0 ? null : new Gamepad(value);
        }
    }

}
