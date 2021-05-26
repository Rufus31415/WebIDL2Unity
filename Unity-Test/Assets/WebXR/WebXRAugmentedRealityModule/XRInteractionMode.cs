
using System;
using System.Runtime.InteropServices;

public enum XRInteractionMode {
ScreenSpace = 0,
WorldSpace = 1
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XRInteractionMode_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XRInteractionMode_set(int parentID, string fieldName, int value);

}
