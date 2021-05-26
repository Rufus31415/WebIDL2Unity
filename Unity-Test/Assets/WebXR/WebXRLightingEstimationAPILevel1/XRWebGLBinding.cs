
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial  class XRWebGLBinding : WebIDL2UnityObject {


    [DllImport("__Internal")]
    private static extern int XRWebGLBinding_GetReflectionCubeMap(int id, int lightProbe);

    public WebGLTexture GetReflectionCubeMap(XRLightProbe lightProbe) {
        var value = XRWebGLBinding_GetReflectionCubeMap(this.ID, lightProbe==null ? 0 : lightProbe.ID);
        return value == 0 ? null : new WebGLTexture(value);
    }
}
