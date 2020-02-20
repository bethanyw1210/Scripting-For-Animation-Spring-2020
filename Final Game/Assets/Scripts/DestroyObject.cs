using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public float destroyTime;
    
    /*void Start()
    {
        Destroy(gameObject, destroyTime);
    }*/

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, destroyTime);
    }
}
