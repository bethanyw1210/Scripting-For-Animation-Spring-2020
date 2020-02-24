using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value = 100f;
    public float minValue = 0f;
    public float maxValue = 100f;

    void Start()
    {
        value = 100f;
    }

    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void UpdateValueRange(float amount)
    {
        if (value < maxValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = maxValue;
        }

        if (value > minValue)
        {
            UpdateValue(amount);
        }

        if (value <= 0f)
        {
            DeadPlayer();
        }
        
    }

    public void DeadPlayer()
    {
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        SceneManager.LoadScene("MainMenu");
    }

}
