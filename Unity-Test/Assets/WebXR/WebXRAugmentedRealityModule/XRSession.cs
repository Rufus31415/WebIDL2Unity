
using System;
using System.Runtime.InteropServices;

public partial  class XRSession : WebIDL2UnityObject {


    public XREnvironmentBlendMode EnvironmentBlendMode {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "environmentBlendMode");
            return (XREnvironmentBlendMode)value;
        }
    }



    public XRInteractionMode InteractionMode {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "interactionMode");
            return (XRInteractionMode)value;
        }
    }

}
