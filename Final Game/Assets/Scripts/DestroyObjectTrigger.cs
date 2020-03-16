using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectTrigger : MonoBehaviour
{
    public string objTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == objTag)
        {
            Destroy(gameObject);
        }
    }
}
