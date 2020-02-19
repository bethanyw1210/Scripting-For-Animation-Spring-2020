using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class ImageBehavior : MonoBehaviour
{
    private Image imageObj;

    private void Start()
    {
        imageObj = GetComponent<Image>();
        imageObj.fillAmount = 10f;
    }
}
