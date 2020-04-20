using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class SimpleCorourtine : MonoBehaviour
{
    public bool CanRun { get; set; } = true;

    public float seconds = 1f;
    private WaitForSeconds waitObj;
    public bool canRun = true;
    public UnityEvent repeatEvent;
    
    private void Awake()
    {
        waitObj = new WaitForSeconds(seconds);
    }

    public void Restart()
    {
        StartCoroutine(OnStartCoroutine());
    }

    public IEnumerator OnStartCoroutine()
    {
        canRun = true;
        while (canRun)
        {
            repeatEvent.Invoke();
            yield return waitObj;
        }
    }
}