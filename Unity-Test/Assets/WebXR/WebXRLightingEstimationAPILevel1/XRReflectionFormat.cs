
using System;
using System.Runtime.InteropServices;

public enum XRReflectionFormat {
Srgba8 = 0,
Rgba16f = 1
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XRReflectionFormat_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XRReflectionFormat_set(int parentID, string fieldName, int value);

}
