
using System;
using System.Runtime.InteropServices;

public enum XRHitTestTrackableType {
Point = 0,
Plane = 1,
Mesh = 2
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XRHitTestTrackableType_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XRHitTestTrackableType_set(int parentID, string fieldName, int value);

}
