
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRSessionInit : WebIDL2UnityObject {


    internal XRSessionInit (int id) : base(id) {}

    public XRSessionInit() : base(WebIDL2UnityGetNewDictionnary()) { }


    public StringArray RequiredFeatures {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "requiredFeatures");
            return value == 0 ? null : new StringArray(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "requiredFeatures", value==null ? 0 : value.ID);
        }
    }



    public StringArray OptionalFeatures {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "optionalFeatures");
            return value == 0 ? null : new StringArray(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "optionalFeatures", value==null ? 0 : value.ID);
        }
    }

}
