
using System;
using System.Runtime.InteropServices;

public enum XRSessionMode {
Inline = 0,
ImmersiveVr = 1,
ImmersiveAr = 2
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XRSessionMode_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XRSessionMode_set(int parentID, string fieldName, int value);

}
