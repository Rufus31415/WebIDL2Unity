
using System;
using System.Runtime.InteropServices;

public enum XRLayerLayout {
Default = 0,
Mono = 1,
Stereo = 2,
StereoLeftRight = 3,
StereoTopBottom = 4
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XRLayerLayout_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XRLayerLayout_set(int parentID, string fieldName, int value);

}
