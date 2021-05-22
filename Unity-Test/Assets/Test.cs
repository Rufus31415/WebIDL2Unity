using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class Test : MonoBehaviour
{
    private XRCylinderLayerInit _a;


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

        
    }


}
