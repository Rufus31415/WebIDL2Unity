
using System;
using System.Runtime.InteropServices;

public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_short_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_short_set(int parentID, string fieldName, int value);

}