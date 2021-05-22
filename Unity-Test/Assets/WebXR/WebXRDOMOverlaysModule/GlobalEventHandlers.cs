
using System;
using System.Runtime.InteropServices;

public partial  class GlobalEventHandlers : WebIDL2UnityObject {


    public EventHandler Onbeforexrselect {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "onbeforexrselect");
            return value == 0 ? null : new EventHandler(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "onbeforexrselect", value.ID);
        }
    }

}
