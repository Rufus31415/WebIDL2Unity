
using System;
using System.Runtime.InteropServices;

public partial  class XRWebGLBinding : WebIDL2UnityObject {


    internal XRWebGLBinding (int id) : base(id) {}



    public double NativeProjectionScaleFactor {
        get {
            var value = WebIDL2Unity_double_get(this.ID, "nativeProjectionScaleFactor");
            return value;
        }
    }








}
