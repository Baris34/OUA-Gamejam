using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcNavMesh : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform[] destinations;
    private int currentDestinationIndex = 0;
    private Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        if (destinations != null && destinations.Length > 0)
        {
            MoveToDestination(destinations[currentDestinationIndex]);
        }
    }

    private void Update()
    {

            float speed = agent.velocity.magnitude;
            animator.SetFloat("Speed", speed);
    }

    public void SetDestinations(Transform[] destinations)
    {
        this.destinations = destinations;
    }

    private void MoveToDestination(Transform destination)
    {
        agent.SetDestination(destination.position);

        currentDestinationIndex++;
        if (currentDestinationIndex < destinations.Length)
        {
            float delay = (currentDestinationIndex == 1) ? 2f : 5f;
            Invoke("MoveToNextDestination", delay);
        }
    }

    private void MoveToNextDestination()
    {
        if (currentDestinationIndex < destinations.Length)
        {
            MoveToDestination(destinations[currentDestinationIndex]);
        }
    }
}
