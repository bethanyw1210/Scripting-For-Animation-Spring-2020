using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

[RequireComponent(typeof(Light))]

public class ControlLight : MonoBehaviour
{
    private Light controlLight;
    private void Start()
    {
        controlLight = GetComponent<Light>();
        controlLight.intensity = 0f;
    }
}
