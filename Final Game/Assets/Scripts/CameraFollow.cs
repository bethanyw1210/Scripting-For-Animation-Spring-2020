using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offSet, offSet2;

    public void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offSet;
        Vector3 desiredPosition2 = player.position + offSet2;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        Vector3 smoothedPosition2 = Vector3.Lerp(desiredPosition2, transform.position, smoothSpeed);
        transform.position = desiredPosition;

        transform.LookAt(player);
    }
}
