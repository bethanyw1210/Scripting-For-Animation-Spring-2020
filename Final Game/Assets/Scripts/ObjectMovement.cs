using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float objSpeed;

    void Update()
    {
        Vector3 newPos = new Vector3(objSpeed, 0, 0);
        transform.position += newPos;
    }
}
