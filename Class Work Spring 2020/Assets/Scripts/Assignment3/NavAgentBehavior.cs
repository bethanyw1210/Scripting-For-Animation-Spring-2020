using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class NavAgentBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player;
    public float speed = 8f;
    private Transform currentDestination;
    private bool canHunt;

    public List<Transform> patrolPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        currentDestination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        canHunt = true;
        currentDestination = player;
    }

    private void OnTriggerExit(Collider other)
    {
        canHunt = false;
        currentDestination = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (canHunt)
        {
            agent.destination = currentDestination.position;
            return;
        }
        /*agent.destination = player.position;*/

/*        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            agent.destination = patrolPoints{i}.position;
            i = (i + 1) % patrolPoints.Count;
        }*/
    }
}
