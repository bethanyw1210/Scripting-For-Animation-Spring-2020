using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class CreateData : ScriptableObject
{
    public int value = 1;

    private void Start()
    {
        value = 0;
    }
    
    public void UpdateValue(int number)
    {
        value += number;
    }
}
