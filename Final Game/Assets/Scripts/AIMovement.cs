using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AIMovement : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform currentDestination;
    public GameObject startObj;
    public Transform destinationObj;
    void Start()
    {
        startObj = new GameObject();
        startObj.transform.position = transform.position;
        currentDestination = transform;
        enemy = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        currentDestination = destinationObj;
    }

    private void OnTriggerExit(Collider other)
    {
        currentDestination = startObj.transform;
    }

    private void Update()
    {
        enemy.destination = currentDestination.position;
    }
}
