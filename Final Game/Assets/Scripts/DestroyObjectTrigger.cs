using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyObjectTrigger : MonoBehaviour
{
    public string objTag;
    public UnityEvent particleSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == objTag)
        {
            particleSystem.Invoke();
            Destroy(gameObject);
        }
    }
}
