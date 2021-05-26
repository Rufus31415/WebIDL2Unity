
using System;
using System.Runtime.InteropServices;

public enum XRReferenceSpaceType {
Viewer = 0,
Local = 1,
LocalFloor = 2,
BoundedFloor = 3,
Unbounded = 4
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XRReferenceSpaceType_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XRReferenceSpaceType_set(int parentID, string fieldName, int value);

}
