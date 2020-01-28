using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Newer : MonoBehaviour
{

    public float floatNumber;
    public int scoreNumber;
    public UnityEvent uEvent;
    
    void Start()
    {
        uEvent.Invoke();
    }
    
    void Update()
    {
        print(floatNumber);
    }
}
