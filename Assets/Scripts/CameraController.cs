using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cameraBehind;
    public Camera cameraOver;
    public bool behindCam = true;
    // Start is called before the first frame update
    void Start()
    {
        cameraBehind.enabled = true;
        cameraOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey("1"))
        //{
        //    if(behindCam == true)
        //    {
        //        cameraOver.enabled = behindCam;
        //        cameraBehind.enabled = !behindCam;
        //    }
        //    else
        //    {
        //        cameraOver.enabled = behindCam;
        //        cameraBehind.enabled = !behindCam;
        //    }

        //    Debug.Log("Hello");
        //}

        //if (Input.GetKey("2"))
        //{
        //    cameraBehind.enabled = true;
        //    cameraOver.enabled = false;
        //}

        if (Input.GetKeyDown("1"))
        {
            cameraBehind.enabled = !cameraBehind.enabled;
            cameraOver.enabled = !cameraOver.enabled;
        }

    }
}
