﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (GetComponent<IntData>().value == 8)
        {
            SceneManager.LoadScene("Shop");
        }
    }
}
