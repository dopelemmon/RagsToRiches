using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class characterAgent : MonoBehaviour
{
    public GameObject characterDestination1;
    public GameObject characterDestination2;
    public GameObject characterDestination3;
    public GameObject characterDestination4;
    public GameObject characterDestination5;
    public GameObject characterDestination6;

    public int destinationNumber;
    NavMeshAgent theAgent;

    // Start is called before the first frame update
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
        destinationNumber = Random.Range(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if (destinationNumber == 1)
        {
            theAgent.SetDestination(characterDestination1.transform.position);
            
        }
        else if (destinationNumber == 2)
        {
            theAgent.SetDestination(characterDestination2.transform.position);
        }
        else if (destinationNumber == 3)
        {
            theAgent.SetDestination(characterDestination3.transform.position);
        }
        else if (destinationNumber == 4)
        {
            theAgent.SetDestination(characterDestination4.transform.position);
        }
        else if (destinationNumber == 5)
        {
            theAgent.SetDestination(characterDestination5.transform.position);
        }
        else if (destinationNumber == 6)
        {
            theAgent.SetDestination(characterDestination6.transform.position);
        }

        destinationNumber = DestinationChange.numberofDestination;
    }
}
