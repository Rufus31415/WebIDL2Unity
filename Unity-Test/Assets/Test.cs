using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class Test : MonoBehaviour
{
    private XRCylinderLayerInit _a;

    private EnumArray<XREye> _arrayEnum;

    private XRSession _session;

    int[] testArray;

    private void Update()
    {
        testArray = new int[1000];
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 100), "set"))
        {
            _a = new XRCylinderLayerInit();

            _a.AspectRatio = 12;

            _a.Radius = -1.2f;

            _a.TextureType = XRTextureType.TextureArray;

        }
        if (GUI.Button(new Rect(200, 0, 100, 100), "get"))
        {
            Debug.Log("_a.AspectRatio = " + _a.AspectRatio);
            Debug.Log("_a.Radius = " + _a.Radius);
            Debug.Log("_a.TextureType = " + _a.TextureType);

            Debug.Log("_a.CentralAngle = " + _a.CentralAngle);
        }

        if (GUI.Button(new Rect(300, 0, 100, 100), "get"))
        {
            _arrayEnum = new EnumArray<XREye>();

            _arrayEnum.Add(XREye.None);
            _arrayEnum.Add(XREye.Right);

            Debug.Log("_arrayEnum.Count = " + _arrayEnum.Count);

            _arrayEnum.Remove(XREye.Right);


            Debug.Log("_arrayEnum.Count = " + _arrayEnum.Count);
            Debug.Log("_arrayEnum[0] = " + _arrayEnum[0]);

            _arrayEnum.Add(XREye.Left);

            Debug.Log("_arrayEnum.Count = " + _arrayEnum.Count);
            Debug.Log("_arrayEnum[1] = " + _arrayEnum[1]);

        }

        if (GUI.Button(new Rect(400, 0, 100, 100), "IsSessionSupported"))
        {

            var promise = NativeJS.Navigator.Xr.IsSessionSupported(XRSessionMode.ImmersiveAr);

            promise.Then((supported) =>
            {
                Debug.Log("AR supported: " + supported);
            });

            NativeJS.Navigator.Xr.IsSessionSupported(XRSessionMode.ImmersiveVr).Then((supported) =>
            {
                Debug.Log("VR supported: " + supported);
            });



        }
        if (GUI.Button(new Rect(500, 0, 100, 100), "RequestSession"))
        {
            var options = new XRSessionInit();
            options.OptionalFeatures = new string[] { "local-floor", "hand-tracking" };
  

            NativeJS.Navigator.Xr.RequestSession(XRSessionMode.ImmersiveVr, options).Then((x)=>
            {
                Debug.Log("got session");
                _session = x;
            });



        }

        if (GUI.Button(new Rect(600, 0, 100, 100), "_session"))
        {
            _session.RequestReferenceSpace(XRReferenceSpaceType.Local).Then(x =>
            {
                Debug.Log("RequestReferenceSpace");
            });

            Debug.Log("Input sources : " + _session.InputSources.Length);

          for(int i=0;i< _session.InputSources[0].Profiles.Count; i++)
            {
                Debug.Log("profile : " + _session.InputSources[0].Profiles[i]);
            }
        }

    }

}
