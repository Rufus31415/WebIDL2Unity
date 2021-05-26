
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRSession : EventTarget {


    public XREnvironmentBlendMode EnvironmentBlendMode {
        get {
            var value = WebIDL2Unity_XREnvironmentBlendMode_get(this.ID, "environmentBlendMode");
            return (XREnvironmentBlendMode)value;
        }
    }



    public XRInteractionMode InteractionMode {
        get {
            var value = WebIDL2Unity_XRInteractionMode_get(this.ID, "interactionMode");
            return (XRInteractionMode)value;
        }
    }

}
