
using System;
using System.Runtime.InteropServices;

public enum XRHandedness {
None = 0,
Left = 1,
Right = 2
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XRHandedness_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XRHandedness_set(int parentID, string fieldName, int value);

}
