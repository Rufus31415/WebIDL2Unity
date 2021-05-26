
using System;
using System.Runtime.InteropServices;

public enum XREnvironmentBlendMode {
Opaque = 0,
AlphaBlend = 1,
Additive = 2
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XREnvironmentBlendMode_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XREnvironmentBlendMode_set(int parentID, string fieldName, int value);

}
