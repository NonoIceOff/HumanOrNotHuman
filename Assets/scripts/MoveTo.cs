using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    // Start is called before the first frame update
       public Transform goal;
       
       void Update () {
          UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
          agent.destination = goal.position; 
       }
}
