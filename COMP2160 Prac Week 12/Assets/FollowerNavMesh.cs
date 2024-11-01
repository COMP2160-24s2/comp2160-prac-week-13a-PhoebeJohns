using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;
public class FollowerNavMesh : MonoBehaviour
{
    private NavMeshAgent agent;

    [SerializeField] private float desiredDistanceToPlayer = 3;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform followTarget;
    private Vector3 targetPos;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        targetPos = transform.position;
    }

    void Update()
    {
        targetPos = transform.position;

        if ((transform.position - followTarget.position).magnitude > desiredDistanceToPlayer)
        {
            targetPos = followTarget.position;
        }

        agent.SetDestination(targetPos);
    }
}
