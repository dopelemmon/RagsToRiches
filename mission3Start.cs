using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mission3Start : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject m3Cam1;
    public GameObject m3Cam2;
    public GameObject enteringCam;
    public GameObject missionEnterVisual;
    public GameObject mission3p2;

    //PLAYER UI
    public GameObject minimap;
    public GameObject playerMoneyUI;
    public GameObject healthUI;
    public GameObject hungerBarUI;

    //FADE IN
    public GameObject fadeIn;
    public GameObject fadeOut;

    //NPC
    public GameObject esmeralda;
    public GameObject sittingMain;

    //SCRIPTS
    public GameObject[] charScripts;
    public GameObject scriptHolder;

    //GLOBAL BOOL IS DONE CHECKER
    public static bool isMission3Startfinish;

    public GameObject tutorialBackground;
    public GameObject[] mission3Tutorial;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(m003Start());
    }
    void Start()
    {
        isMission3Startfinish = false;
    }

    IEnumerator m003Start()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        fadeIn.SetActive(false);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        mainPlayer.SetActive(false);
        minimap.SetActive(false);
        playerMoneyUI.SetActive(false);
        healthUI.SetActive(false);
        hungerBarUI.SetActive(false);
        esmeralda.SetActive(true);
        sittingMain.SetActive(true);
        m3Cam2.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeIn.SetActive(true);
        fadeOut.SetActive(false);
        yield return new WaitForSeconds(2);
        scriptHolder.SetActive(true);
        charScripts[0].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam2.SetActive(false);
        m3Cam1.SetActive(true);
        charScripts[0].SetActive(false); 
        charScripts[1].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam1.SetActive(false);
        m3Cam2.SetActive(true);
        charScripts[1].SetActive(false);
        charScripts[2].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam2.SetActive(false);
        m3Cam1.SetActive(true);
        charScripts[2].SetActive(false);
        charScripts[3].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam1.SetActive(false);
        m3Cam2.SetActive(true);
        charScripts[3].SetActive(false);
        charScripts[4].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam2.SetActive(false);
        m3Cam1.SetActive(true);
        charScripts[4].SetActive(false);
        charScripts[5].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam1.SetActive(false);
        m3Cam2.SetActive(true);
        charScripts[5].SetActive(false);
        charScripts[6].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam2.SetActive(false);
        m3Cam1.SetActive(true);
        charScripts[6].SetActive(false);
        charScripts[7].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam1.SetActive(false);
        m3Cam2.SetActive(true);
        charScripts[7].SetActive(false);
        charScripts[8].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam2.SetActive(false);
        m3Cam1.SetActive(true);
        charScripts[8].SetActive(false);
        charScripts[9].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam1.SetActive(false);
        m3Cam2.SetActive(true);
        charScripts[9].SetActive(false);
        charScripts[10].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam2.SetActive(false);
        m3Cam1.SetActive(true);
        charScripts[10].SetActive(false);
        charScripts[11].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam1.SetActive(false);
        m3Cam2.SetActive(true);
        charScripts[11].SetActive(false);
        charScripts[12].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam2.SetActive(false);
        m3Cam1.SetActive(true);
        charScripts[12].SetActive(false);
        charScripts[13].SetActive(true);
        yield return new WaitForSeconds(4);
        m3Cam1.SetActive(false);
        m3Cam2.SetActive(true);
        charScripts[13].SetActive(false);
        charScripts[14].SetActive(true);
        yield return new WaitForSeconds(4);
        fadeIn.SetActive(false);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        scriptHolder.SetActive(false);
        charScripts[14].SetActive(false);
        m3Cam2.SetActive(false);
        sittingMain.SetActive(false);
        mainPlayer.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(false);
        fadeIn.SetActive(true);
        minimap.SetActive(true);
        playerMoneyUI.SetActive(true);
        healthUI.SetActive(true);
        hungerBarUI.SetActive(true);

        isMission3Startfinish = true;
        tutorialBackground.SetActive(true);
        mission3Tutorial[0].SetActive(true);
        yield return new WaitForSeconds(4);
        mission3Tutorial[0].SetActive(false);
        mission3Tutorial[1].SetActive(true);
        yield return new WaitForSeconds(4);
        mission3Tutorial[1].SetActive(false);
        mission3Tutorial[2].SetActive(true);
        yield return new WaitForSeconds(4);
        mission3Tutorial[2].SetActive(false);
        tutorialBackground.SetActive(false);
    }
}
