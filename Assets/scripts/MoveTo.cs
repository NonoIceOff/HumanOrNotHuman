using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public Transform goal;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update () {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal.position; 

        animator.SetFloat("Move", agent.velocity.magnitude);
    }

}