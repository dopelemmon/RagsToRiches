using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M003buyingCoffee : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject fadeIn;
    public GameObject fadeOut;
    public GameObject coffeeCam1;
    public GameObject venDor;
    public GameObject nextButton;
    public GameObject mission3finish;

    public GameObject goingOffice;

    public GameObject minText;


    public GameObject coffeeIcon;

    public GameObject[] coffeeBuyScript;
    public GameObject scriptHolder;
    public GameObject[] playerHud;

    public bool isMission3StartDone;
    public static bool boughtCoffee;

    bool isbButtonpressed;
    bool isScriptFinished;
    bool isAnimP1isFinished;

    int scriptIncrement;

    int coroutineCounter;
    int breakCounter;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(buyCoffeeAnimP1());

    }
    // Start is called before the first frame update
    void Start()
    {
        isbButtonpressed = false;
        isScriptFinished = false;
        coroutineCounter = 1;
        boughtCoffee = false;
    }

    // Update is called once per frame
    void Update()
    {
        isMission3StartDone = mission3Start.isMission3Startfinish;
        showScript();
        if (isScriptFinished)
        {
            if (coroutineCounter == 1)
            {
                StartCoroutine(buyCoffeeAnimP2());
                coroutineCounter--;
                boughtCoffee = true;
            }
            
        }
    }

    IEnumerator buyCoffeeAnimP1()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;

        fadeOut.SetActive(true);
        fadeIn.SetActive(false);
        goingOffice.SetActive(false);
        playerHud[0].SetActive(false);
        playerHud[1].SetActive(false);
        playerHud[2].SetActive(false);
        playerHud[3].SetActive(false);
        yield return new WaitForSeconds(2);
        mainPlayer.SetActive(false);
        coffeeCam1.SetActive(true);
        coffeeIcon.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(false);
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(2);
        scriptHolder.SetActive(true);
        
        nextButton.SetActive(true);

        isAnimP1isFinished = true;

        
    }
    IEnumerator buyCoffeeAnimP2()
    {
        fadeIn.SetActive(false);
        fadeOut.SetActive(true);
        coffeeBuyScript[5].SetActive(false);
        scriptHolder.SetActive(false);
        yield return new WaitForSeconds(2);
        mainPlayer.SetActive(true);
        coffeeCam1.SetActive(false);
        yield return new WaitForSeconds(2);
        playerHud[0].SetActive(true);
        playerHud[1].SetActive(true);
        playerHud[2].SetActive(true);
        playerHud[3].SetActive(true);
        fadeOut.SetActive(false);
        fadeIn.SetActive(true);
        mission3finish.SetActive(true);

        
    }
    IEnumerator buyCoffeeWait7Min()
    {
        fadeIn.SetActive(false);
        fadeOut.SetActive(true);
        scriptHolder.SetActive(false);
        yield return new WaitForSeconds(2);
        minText.SetActive(true);
        yield return new WaitForSeconds(2);
        minText.SetActive(false);
        fadeOut.SetActive(false);
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(2);
        scriptHolder.SetActive(true);
    }

    public void showScript()
    {
        if (isAnimP1isFinished)
        {
            if(scriptIncrement == 0)
            {
                coffeeBuyScript[0].SetActive(true);
            }
            else if (scriptIncrement == 1)
            {
                coffeeBuyScript[0].SetActive(false);
                coffeeBuyScript[1].SetActive(true);
            }
            else if (scriptIncrement == 2)
            {
                coffeeBuyScript[1].SetActive(false);
                coffeeBuyScript[2].SetActive(true);
            }
            else if (scriptIncrement == 3)
            {
                coffeeBuyScript[2].SetActive(false);
                coffeeBuyScript[3].SetActive(true);
            }
            else if (scriptIncrement == 4)
            {
                StartCoroutine(buyCoffeeWait7Min());
                scriptIncrement++;
            }
            else if (scriptIncrement == 5)
            {
                coffeeBuyScript[3].SetActive(false);
                coffeeBuyScript[4].SetActive(true);
            }
            else if (scriptIncrement == 6)
            {
                coffeeBuyScript[4].SetActive(false);
                coffeeBuyScript[5].SetActive(true);


            }
            else if (scriptIncrement == 7)
            {
                nextButton.SetActive(false);
                isScriptFinished = true;

            }
        }

        
    }

    public void nextButtonPressed()
    {
        if(scriptIncrement >= 0 && scriptIncrement <= 6)
        {
            scriptIncrement++;
            Debug.Log("the script increment is " + scriptIncrement);
        }
    }
}
