using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mission3Finish : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject M3cam1;
    public GameObject officeEnter;
    public GameObject thisMissionTexture;
    public GameObject fadeIn;
    public GameObject fadeOut;
    public GameObject misison4Start;

    public GameObject addmoneyText;
    

    public GameObject OldladySitting;

    public GameObject[] missionFinishScript;
    public GameObject scriptHolder;

    public GameObject[] playerHudUI;

    public GameObject nextButton;

    public bool isAnimp1finish;
    public bool isScriptFinished;

    public int finalAnimCount;
    public int scriptIncrement;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(finishingAnim());

    }
    void Start()
    {
        finalAnimCount = 1;
        isAnimp1finish = false;
        isScriptFinished = false;
        scriptIncrement = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scripts();
        if (isScriptFinished)
        {
            if (finalAnimCount == 1)
            {
                StartCoroutine(finishingAnim2());
                finalAnimCount--;
            }
        }
    }
    IEnumerator finishingAnim()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        fadeIn.SetActive(false);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        mainPlayer.SetActive(false);
        M3cam1.SetActive(true);
        OldladySitting.SetActive(true);
        playerHudUI[0].SetActive(false);
        playerHudUI[1].SetActive(false);
        playerHudUI[2].SetActive(false);
        playerHudUI[3].SetActive(false);
        yield return new WaitForSeconds(2);
        fadeIn.SetActive(true);
        fadeOut.SetActive(false);

        isAnimp1finish = true;

    }

    IEnumerator finishingAnim2()
    {
        fadeOut.SetActive(true);
        fadeIn.SetActive(false);
        yield return new WaitForSeconds(2);
        mainPlayer.SetActive(true);
        M3cam1.SetActive(false);
        missionFinishScript[1].SetActive(false);
        nextButton.SetActive(false);
        scriptHolder.SetActive(false);
        playerHudUI[0].SetActive(true);
        playerHudUI[1].SetActive(true);
        playerHudUI[2].SetActive(true);
        playerHudUI[3].SetActive(true);
        yield return new WaitForSeconds(2);
        fadeIn.SetActive(true);
        fadeOut.SetActive(false);
        yield return new WaitForSeconds(2);
        addmoneyText.SetActive(true);
        yield return new WaitForSeconds(2);
        addmoneyText.SetActive(false);

        mainPlayer.GetComponent<playerMoney>().addMoney(1000);
        misison4Start.SetActive(true);
    }

    public void scripts()
    {
        if (isAnimp1finish == true)
        {
            Debug.Log("animp1finished");
            if (scriptIncrement == 0)
            {
                Debug.Log("scrtpt increment "+scriptIncrement);
                scriptHolder.SetActive(true);
                nextButton.SetActive(true);
                missionFinishScript[0].SetActive(true);
                
            }
            else if (scriptIncrement == 1)
            {
                missionFinishScript[0].SetActive(false);
                missionFinishScript[1].SetActive(true);
                
            }
            else if(scriptIncrement == 2)
            {
                scriptHolder.SetActive(false);
                nextButton.SetActive(false);
                isScriptFinished = true;
            }
        }
    }

    public void nextB()
    {
        if (scriptIncrement >=0 && scriptIncrement <= 2)
        {
            scriptIncrement++;
        }
    }
}
