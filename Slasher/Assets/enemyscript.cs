using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyscript : MonoBehaviour
{
    NavMeshAgent badguy1;
    // Start is called before the first frame update
    void Start()
    {
        badguy1=GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        badguy1.SetDestination(GameObject.FindWithTag("Player").transform.position);
        
    }
}
