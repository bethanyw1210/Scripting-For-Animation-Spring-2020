using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    public int health;
    public float score;
    public UnityEvent lostHealth, lostScore, newHealth;

    private void OnTriggerEnter(Collider other)
    {
        lostHealth.Invoke();
        health--;
    }

    private void OnTriggerStay(Collider other)
    {
        lostScore.Invoke();
        health--;
        print("Loosing health!");
    }

    private void OnTriggerExit(Collider other)
    {
        newHealth.Invoke();
        score--;
    }
}
