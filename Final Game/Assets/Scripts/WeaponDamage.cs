using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    public string objTag;
    public GameObject enemy;
    private int damageCounter = 2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == objTag)
        {
            damageCounter--;
        }
        
        if (other.tag == objTag && damageCounter <= 0)
        {
            Destroy(other.gameObject);
        }
    }
}
