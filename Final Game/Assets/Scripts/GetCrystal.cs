using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCrystal : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<CrystalCounter>().UpdateCount();
        Destroy(gameObject);
    }
}
