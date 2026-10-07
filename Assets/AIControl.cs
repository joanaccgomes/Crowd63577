using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    public GameObject goal;
    NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       agent = this.GetComponent<NavMeshAgent>();
       agent.SetDestination(goal.transform.position); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
