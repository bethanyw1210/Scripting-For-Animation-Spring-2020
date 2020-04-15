using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformBehavior : MonoBehaviour
{
    public string otherTagString;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(otherTagString))
        {
            transform.parent = other.transform;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}
