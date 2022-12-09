using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tutorial001 : MonoBehaviour
{
    public GameObject tutor001Panel;
    public GameObject[] apartmentIntro;
    //public GameObject[] eatIntro;
    public GameObject[] saveTutorial;
    public GameObject[] transportationIntro;
    public GameObject mainplayer;
    public GameObject tutorCam;
    public GameObject tutorial002;
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(tutorialStart());
    }

    IEnumerator tutorialStart()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(6);
        mainplayer.SetActive(false);
        tutorCam.SetActive(true);
        tutor001Panel.SetActive(true);
        apartmentIntro[0].SetActive(true);
        yield return new WaitForSeconds(4);
        apartmentIntro[0].SetActive(false);
        apartmentIntro[1].SetActive(true);
        yield return new WaitForSeconds(4);
        apartmentIntro[1].SetActive(false);
        //eatIntro[0].SetActive(true);
        yield return new WaitForSeconds(4);
        //eatIntro[0].SetActive(false);
        saveTutorial[0].SetActive(true);
        yield return new WaitForSeconds(4);
        saveTutorial[0].SetActive(false);
        saveTutorial[1].SetActive(true);
        yield return new WaitForSeconds(4);
        saveTutorial[1].SetActive(false);
        tutor001Panel.SetActive(false);
        yield return new WaitForSeconds(2);
        tutorCam.SetActive(false);
        mainplayer.SetActive(true);
        tutorial002.SetActive(true);

    }
}
