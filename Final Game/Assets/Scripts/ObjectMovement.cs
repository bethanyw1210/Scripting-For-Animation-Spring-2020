using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    private float objSpeed = 1f;

    void Update()
    {
        Vector3 newPos = new Vector3(objSpeed, 0, 0);
        transform.position += newPos;
    }
}
