using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyscript : MonoBehaviour
{
    NavMeshAgent badguy1;
    public GameObject[] limbs;
    public bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        badguy1=GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(alive)
        {
            badguy1.SetDestination(GameObject.FindWithTag("Player").transform.position);
        }
        if(!alive)
        {
            badguy1.speed = 0;
            foreach(GameObject limb in limbs)
            {
                limb.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }
}
