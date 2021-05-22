
using System;
using System.Runtime.InteropServices;

public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static ulong WebIDL2Unity_unsigned_long_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_unsigned_long_set(int parentID, string fieldName, ulong value);

}