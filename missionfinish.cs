using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missionfinish : MonoBehaviour
{
    public GameObject mainChar;
    public GameObject oldLady;
    public GameObject fakeChartalk;
    public GameObject fadeOut;
    public GameObject fadeIn;
    public GameObject firstCam;
    public GameObject minimap;
    public GameObject minimapborder;
    public GameObject camtowardsplayer;
    public GameObject camtowardslady;
    public GameObject background;
    public GameObject script1;
    public GameObject script2;
    public GameObject script3;
    public GameObject script4;
    public GameObject script5;
    public GameObject script6;
    public GameObject script7;

    public GameObject missionTextBg;
    public GameObject[] missionFinishText;

    public GameObject mission2endCam;

    //MISSION 3 START  
    public GameObject mission3Start;
    public GameObject goinginCompany;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(finishmission());
    }

    IEnumerator finishmission()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        mainChar.SetActive(false);
        minimap.SetActive(false);
        minimapborder.SetActive(false);
        firstCam.SetActive(true);
        fakeChartalk.SetActive(true);
        fadeIn.SetActive(false);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(false);
        firstCam.SetActive(true);
        camtowardsplayer.SetActive(true);
        background.SetActive(true);
        script1.SetActive(true);
        yield return new WaitForSeconds(4);
        camtowardslady.SetActive(true);
        camtowardsplayer.SetActive(false);
        script1.SetActive(false);
        script2.SetActive(true);
        yield return new WaitForSeconds(4);
        camtowardsplayer.SetActive(true);
        camtowardslady.SetActive(false);
        script2.SetActive(false);
        script3.SetActive(true);
        yield return new WaitForSeconds(4);
        camtowardslady.SetActive(true);
        camtowardsplayer.SetActive(false);
        script3.SetActive(false);
        script4.SetActive(true);
        yield return new WaitForSeconds(4);
        camtowardsplayer.SetActive(true);
        camtowardslady.SetActive(false);
        script4.SetActive(false);
        script5.SetActive(true);
        yield return new WaitForSeconds(4);
        camtowardslady.SetActive(true);
        camtowardsplayer.SetActive(false);
        script5.SetActive(false);
        script6.SetActive(true);
        yield return new WaitForSeconds(4);
        camtowardsplayer.SetActive(true);
        camtowardslady.SetActive(false);
        script6.SetActive(false);
        script7.SetActive(true);
        yield return new WaitForSeconds(4);
        camtowardsplayer.SetActive(false);
        script7.SetActive(false);
        background.SetActive(false);
        mission2endCam.SetActive(true);
        firstCam.SetActive(false);
        fakeChartalk.SetActive(false);
        /* fadeIn.SetActive(false);
         fadeOut.SetActive(true);
         yield return new WaitForSeconds(2);
         
         fadeOut.SetActive(false);
         yield return new WaitForSeconds(2);
         fadeIn.SetActive(true);*/
        yield return new WaitForSeconds(2);
        mission3Start.SetActive(true);
        goinginCompany.SetActive(true);
        yield return new WaitForSeconds(1);
        missionTextBg.SetActive(true);
        missionFinishText[0].SetActive(true);
        yield return new WaitForSeconds(3);
        missionFinishText[0].SetActive(false);
        missionFinishText[1].SetActive(true);
        yield return new WaitForSeconds(3);
        missionFinishText[1].SetActive(false);
        missionFinishText[2].SetActive(true);
        yield return new WaitForSeconds(3);
        missionFinishText[1].SetActive(false);
        missionTextBg.SetActive(false);
        minimapborder.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeIn.SetActive(false);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        mission2endCam.SetActive(false);
        mainChar.SetActive(true);
        minimap.SetActive(true);
        oldLady.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(false);
        fadeIn.SetActive(true);
    }
}
