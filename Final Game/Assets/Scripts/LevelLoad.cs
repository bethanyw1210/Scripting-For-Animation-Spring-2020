using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]

public class LevelLoad : ScriptableObject
{
    public string level;
    
    public void LoadScene()
    {
        SceneManager.LoadScene("Shop");
    }
}
