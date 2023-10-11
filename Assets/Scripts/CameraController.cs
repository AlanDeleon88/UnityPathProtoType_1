using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cameraBehind;
    public Camera cameraOver;
    public bool behindCam = true;
    public KeyCode switchKey;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(switchKey))
        {
            cameraBehind.enabled = !cameraBehind.enabled;
            cameraOver.enabled = !cameraOver.enabled;
        }

    }
}
