
using System;
using System.Runtime.InteropServices;

public enum XRVisibilityState {
Visible = 0,
VisibleBlurred = 1,
Hidden = 2
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XRVisibilityState_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XRVisibilityState_set(int parentID, string fieldName, int value);

}
