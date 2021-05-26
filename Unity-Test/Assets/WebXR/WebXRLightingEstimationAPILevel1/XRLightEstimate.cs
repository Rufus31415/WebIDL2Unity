
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRLightEstimate : WebIDL2UnityObject {


    internal XRLightEstimate (int id) : base(id) {}


    public Float32Array SphericalHarmonicsCoefficients {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "sphericalHarmonicsCoefficients");
            return value == 0 ? null : new Float32Array(value);
        }
    }



    public DOMPointReadOnly PrimaryLightDirection {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "primaryLightDirection");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }



    public DOMPointReadOnly PrimaryLightIntensity {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "primaryLightIntensity");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }

}
