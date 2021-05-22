
using System;
using System.Runtime.InteropServices;

public partial  class XRFrame : WebIDL2UnityObject {


    internal XRFrame (int id) : base(id) {}


    public XRSession Session {
        get {
            var value = WebIDL2Unity_short_get(this.ID, "session");
            return value == 0 ? null : new XRSession(value);
        }
    }



}
