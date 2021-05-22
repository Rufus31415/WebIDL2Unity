
using System;
using System.Runtime.InteropServices;

public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static bool WebIDL2Unity_boolean_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_boolean_set(int parentID, string fieldName, bool value);

}