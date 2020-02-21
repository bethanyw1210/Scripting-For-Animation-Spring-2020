﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnter;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnter.Invoke();
    }
}
