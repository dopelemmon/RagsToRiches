using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thiefcollider : MonoBehaviour
{
    public GameObject thiefgoingdown;
    public GameObject mainchar;
    public GameObject maincharget;
    public GameObject thiefgoingup;
    public GameObject thief;
    public GameObject fadeOut;
    public GameObject thirdCam;
    public GameObject backCam;
    public GameObject missionfinish;
    public GameObject sad;
    public GameObject mainThief;
    
    void OnTriggerEnter(Collider Player)
    {
        StartCoroutine(isinCollider());
    }

    IEnumerator isinCollider()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        mainThief.GetComponent<ThiefMovement>().enabled = false;
        fadeOut.SetActive(true);
        backCam.SetActive(true);
        mainchar.SetActive(false);
        thief.SetActive(false);
        
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(false);
        thiefgoingdown.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(false);
        maincharget.SetActive(true);
        thirdCam.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        thiefgoingdown.SetActive(false);
        maincharget.SetActive(false);
        yield return new WaitForSeconds(1);
        fadeOut.SetActive(false);
        thirdCam.SetActive(false);
        backCam.SetActive(false);
        mainchar.SetActive(true);
        
        missionfinish.SetActive(true);
        thiefgoingup.SetActive(true);

    }
}
