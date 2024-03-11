using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToTarget : MonoBehaviour
{
    [SerializeField] private Transform m_target;
    private void Start()
    {
        //GetComponent<NavMeshAgent>().destination = m_target.position;
    }
     void Update()
    {
        GetComponent<NavMeshAgent>().destination = m_target.position;
    }
}
