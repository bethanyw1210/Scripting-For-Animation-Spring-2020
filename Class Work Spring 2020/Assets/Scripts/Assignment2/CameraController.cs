using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]

public class CameraController : MonoBehaviour
{
    private Camera cameraObj;
    void Start()
    {
        cameraObj = GetComponent<Camera>();
        cameraObj.aspect = 5f;

    }

}
