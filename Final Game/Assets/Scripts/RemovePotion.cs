using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RemovePotion : MonoBehaviour
{
    public UnityEvent removePotion;

    private void OnTriggerEnter(Collider other)
    {
        removePotion.Invoke();
    }
}
