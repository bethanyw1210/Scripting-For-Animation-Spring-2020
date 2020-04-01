using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine2 : MonoBehaviour
{
    private WaitForFixedUpdate waitObj;
    public bool canRun = true;
    
    void Start()
    {
        waitObj = new WaitForFixedUpdate();
        StartCoroutine(OnStartCoroutine());
    }

    public IEnumerator OnStartCoroutine()
    {
        while (canRun)
        {
            yield return waitObj;
            print("Repeating");
        }
    }

    private void Update()
    {
        print("Updating");
    }
}
