﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StringData : ScriptableObject
{
    public string stringName;

    public void StringName()
    {
        stringName = name;
    }
}
