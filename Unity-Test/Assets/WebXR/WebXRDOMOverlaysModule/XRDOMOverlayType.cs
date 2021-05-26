
using System;
using System.Runtime.InteropServices;

public enum XRDOMOverlayType {
Screen = 0,
Floating = 1,
HeadLocked = 2
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XRDOMOverlayType_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XRDOMOverlayType_set(int parentID, string fieldName, int value);

}
