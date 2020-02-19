using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CrystalCounter : MonoBehaviour
{
    public UnityEvent CrystalCount;
    
    public void UpdateCount()
    {
        CrystalCount.Invoke();
    }
}
