using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArray : MonoBehaviour
{
    public List<string> enemyName;
    public string enemyObj;

    private void AddToList()
    {
        enemyName.Add(enemyObj);
    }

    private void RemoveFromList()
    {
        for (int i = 0; i < enemyName.Count; i++)
        {
            enemyName.Remove(enemyObj);
        }
    }

    public void NameList()
    {
        foreach (var obj in enemyName)
        {
            Debug.Log(obj);
        }
    }
}
