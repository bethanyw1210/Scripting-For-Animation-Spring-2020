﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextBehavior : MonoBehaviour
{
    private Text textObj;
    /*public IntData dataObj;*/

    private void Start()
    {
        textObj = GetComponent<Text>();
    }
/*

    private void Update()
    {
        textObj.text = dataObj.value.ToString();
    }*/

    public void ChangeText(string message)
    {
        textObj.text = message;
    }

    public void ChangeText(IntData obj)
    {
        textObj.text = obj.value.ToString();
    }
}
