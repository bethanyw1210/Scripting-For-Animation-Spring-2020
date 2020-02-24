using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{
    public string levelLoad;

    private void OnTriggerEnter(Collider other)
    {
        if (GetComponent<CreateData>().value == 8)
        {
            SceneManager.LoadScene(levelLoad);
        }
    }
}
