
using System;
using System.Runtime.InteropServices;

public partial  class XRSessionInit : WebIDL2UnityObject {


    internal XRSessionInit (int id) : base(id) {}

    public XRSessionInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public Sequence<string> RequiredFeatures {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "requiredFeatures");
            return new Sequence<string>(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "requiredFeatures", value.ID);
        }
    }



    public Sequence<string> OptionalFeatures {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "optionalFeatures");
            return new Sequence<string>(value);
        }
        set {
            WebIDL2Unity_short_set(this.ID, "optionalFeatures", value.ID);
        }
    }

}
