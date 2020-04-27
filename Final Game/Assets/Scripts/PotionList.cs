using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class PotionList : ScriptableObject
{
    public List<GameObject> potionType;

    public void NameList()
    {
        foreach (GameObject obj in potionType)
        {
            Debug.Log("Small Potion heals 5 health.");
            Debug.Log("Medium Potion heals 15 health.");
            Debug.Log("Large potion heals 30 health.");
        }
    }
}
