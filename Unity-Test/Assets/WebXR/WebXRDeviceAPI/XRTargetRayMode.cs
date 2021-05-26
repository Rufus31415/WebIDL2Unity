
using System;
using System.Runtime.InteropServices;

public enum XRTargetRayMode {
Gaze = 0,
TrackedPointer = 1,
Screen = 2
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XRTargetRayMode_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XRTargetRayMode_set(int parentID, string fieldName, int value);

}
