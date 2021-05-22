
using System;
using System.Runtime.InteropServices;

public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static byte WebIDL2Unity_octet_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_octet_set(int parentID, string fieldName, byte value);

}