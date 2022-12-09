using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationChange : MonoBehaviour
{
    public static int numberofDestination;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "pedestrians")
        {
            numberofDestination = Random.Range(1, 6);
            

            Debug.Log("the new number is " + numberofDestination);
        }
    }

    void Update()
    {
        
    }
}
