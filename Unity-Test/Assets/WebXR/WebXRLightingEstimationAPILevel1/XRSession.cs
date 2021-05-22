
using System;
using System.Runtime.InteropServices;

public partial  class XRSession : WebIDL2UnityObject {



    public XRReflectionFormat PreferredReflectionFormat {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "preferredReflectionFormat");
            return (XRReflectionFormat)value;
        }
    }

}
