
using System;
using System.Runtime.InteropServices;

public enum XRHandJoint {
Wrist = 0,
ThumbMetacarpal = 1,
ThumbPhalanxProximal = 2,
ThumbPhalanxDistal = 3,
ThumbTip = 4,
IndexFingerMetacarpal = 5,
IndexFingerPhalanxProximal = 6,
IndexFingerPhalanxIntermediate = 7,
IndexFingerPhalanxDistal = 8,
IndexFingerTip = 9,
MiddleFingerMetacarpal = 10,
MiddleFingerPhalanxProximal = 11,
MiddleFingerPhalanxIntermediate = 12,
MiddleFingerPhalanxDistal = 13,
MiddleFingerTip = 14,
RingFingerMetacarpal = 15,
RingFingerPhalanxProximal = 16,
RingFingerPhalanxIntermediate = 17,
RingFingerPhalanxDistal = 18,
RingFingerTip = 19,
PinkyFingerMetacarpal = 20,
PinkyFingerPhalanxProximal = 21,
PinkyFingerPhalanxIntermediate = 22,
PinkyFingerPhalanxDistal = 23,
PinkyFingerTip = 24
}


public abstract partial class WebIDL2UnityObject
{
     [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_XRHandJoint_get(int parentID, string fieldName);

     [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_XRHandJoint_set(int parentID, string fieldName, int value);

}
