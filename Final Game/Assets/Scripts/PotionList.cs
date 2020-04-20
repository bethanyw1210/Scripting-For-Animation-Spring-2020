using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class PotionList : ScriptableObject
{
    public List<GameObject> potionType;
    public GameObject potionObj1, potionObj2, potionObj3;

    public void AddToList()
    {
        potionType.Add(potionObj1);
        potionType.Add(potionObj2);
        potionType.Add(potionObj3);
    }

    public void RemoveFromList()
    {
        for (int i = 0; i < potionType.Count; i++)
        {
            potionType.Remove(potionObj1);
            potionType.Remove(potionObj2);
            potionType.Remove(potionObj3);
        } 
    }

    public void NameList()
    {
        foreach (var obj in potionType)
        {
            Debug.Log(obj);
        }
    }
}
