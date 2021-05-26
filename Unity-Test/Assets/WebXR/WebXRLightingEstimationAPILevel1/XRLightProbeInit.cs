
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRLightProbeInit : WebIDL2UnityObject {


    internal XRLightProbeInit (int id) : base(id) {}

    public XRLightProbeInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public XRReflectionFormat ReflectionFormat {
        get {
            var value = WebIDL2Unity_XRReflectionFormat_get(this.ID, "reflectionFormat");
            return (XRReflectionFormat)value;
        }
        set {
            WebIDL2Unity_XRReflectionFormat_set(this.ID, "reflectionFormat", (int)value);
        }
    }

}
