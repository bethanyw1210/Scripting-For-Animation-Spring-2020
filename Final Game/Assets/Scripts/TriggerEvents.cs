using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnter;
    public UnityEvent triggerExit;
    public string objTag;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnter.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExit.Invoke();
    }
}
