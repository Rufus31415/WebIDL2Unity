
using System;
using System.Runtime.InteropServices;

public enum XRTextureType {
Texture = 0,
TextureArray = 1
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XRTextureType_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XRTextureType_set(int parentID, string fieldName, int value);

}
