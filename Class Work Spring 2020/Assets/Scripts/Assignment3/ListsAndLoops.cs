using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ListsAndLoops : ScriptableObject
{
    //array size cannot be changed via code
    public List<string> stringList;
    public string singleString;

    public void AddToList(string stringObj)
    {
        stringList.Add(stringObj);
    }

    public void RemoveFromList(string stringObj)
    {
        for (int i = 0; i < stringList.Count; i++)
        {
            if (stringList[i] == stringObj)
            {
                stringList.Remove(stringObj);
            }
        }
    }

    public void SortList()
    {
        stringList.Sort();
    }
    
    public void CheckList()
    {
        foreach (var obj in stringList)
        {
            if (obj == singleString)
            {
                Debug.Log(obj);
            }
        }
    }
}
