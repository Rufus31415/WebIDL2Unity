
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public  class XRPermissionStatus : PermissionStatus {


    internal XRPermissionStatus (int id) : base(id) {}


    public StringArray Granted {
        get {
            var value = WebIDL2Unity_reference_get(this.ID, "granted");
            return value == 0 ? null : new StringArray(value);
        }
        set {
            WebIDL2Unity_reference_set(this.ID, "granted", value==null ? 0 : value.ID);
        }
    }

}
