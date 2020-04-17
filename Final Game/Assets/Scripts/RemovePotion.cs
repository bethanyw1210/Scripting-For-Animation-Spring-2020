using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePotion : MonoBehaviour
{
    public List<GameObject> potionObj;

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < potionObj.Count; i++)
        {
            potionObj.Remove(other.gameObject);
        }
    }

    public void NameList()
    {
        foreach (var obj in potionObj)
        {
            Debug.Log(obj);
        }
    }
}
