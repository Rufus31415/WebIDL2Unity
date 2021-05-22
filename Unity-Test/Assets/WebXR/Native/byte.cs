
using System;
using System.Runtime.InteropServices;

public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static sbyte WebIDL2Unity_byte_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_byte_set(int parentID, string fieldName, sbyte value);

}