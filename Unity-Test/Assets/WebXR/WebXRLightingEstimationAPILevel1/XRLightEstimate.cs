
using System;
using System.Runtime.InteropServices;

public  class XRLightEstimate : WebIDL2UnityObject {


    internal XRLightEstimate (int id) : base(id) {}


    public FrozenArray<float> SphericalHarmonicsCoefficients {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "sphericalHarmonicsCoefficients");
            return new FrozenArray<float>(value);
        }
    }



    public DOMPointReadOnly PrimaryLightDirection {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "primaryLightDirection");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }



    public DOMPointReadOnly PrimaryLightIntensity {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "primaryLightIntensity");
            return value == 0 ? null : new DOMPointReadOnly(value);
        }
    }

}
