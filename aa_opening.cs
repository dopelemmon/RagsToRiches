using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aa_opening : MonoBehaviour
{
    public GameObject fadein;
    public GameObject theText;
    public GameObject initialCamera;
    public GameObject fadeOut;
    public GameObject thePlayer;
    public GameObject sittingPlayer;
    public GameObject minimap;
    public GameObject pressW;
    public GameObject Objectives;
    public GameObject movement;
    public GameObject Healthbar;
    public GameObject hungerBar;
    public GameObject playermoney;
    public GameObject panelbackground;

    public Transform saveGametransform;

    public GameObject tutorialBackground;
    public GameObject[] healthAndHunger;
    // Start is called before the first frame update
    void Start()
    {
        if (saveGame.isGameSaved == false)
        {
            StartCoroutine(OpenBegin());
        }
        else
        {
            fadein.SetActive(false);
            theText.SetActive(false);
            initialCamera.SetActive(false);
            thePlayer.SetActive(true);
            sittingPlayer.SetActive(false);
            minimap.SetActive(true);
            pressW.SetActive(true);

            movement.SetActive(true);
            Healthbar.SetActive(true);
            hungerBar.SetActive(true);
            playermoney.SetActive(true);
            movement.GetComponent<PlayMakerFSM>().enabled = true;
            thePlayer.transform.position = saveGametransform.transform.position;

        }
    }

    IEnumerator OpenBegin()
    {
        yield return new WaitForSeconds(1);

        theText.SetActive(true);
        yield return new WaitForSeconds(1);
        fadein.GetComponent<Animator>().enabled = true;
        initialCamera.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        fadein.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        initialCamera.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        fadein.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        thePlayer.SetActive(true);
        minimap.SetActive(true);
        Healthbar.SetActive(true);
        hungerBar.SetActive(true);
        playermoney.SetActive(true);
        fadein.SetActive(false);
        initialCamera.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        fadein.SetActive(true);
        fadeOut.SetActive(false);
        sittingPlayer.SetActive(false);
        yield return new WaitForSeconds(1);
        pressW.SetActive(true);
        yield return new WaitForSeconds(3);
        movement.GetComponent<PlayMakerFSM>().enabled = true;
        yield return new WaitForSeconds(5);
        pressW.SetActive(false);
        yield return new WaitForSeconds(3);
       // panelbackground.SetActive(true);
        Objectives.SetActive(true);
        yield return new WaitForSeconds(5);
       // panelbackground.SetActive(false);
        Objectives.SetActive(false);
        tutorialBackground.SetActive(true);
        healthAndHunger[0].SetActive(true);
        Healthbar.SetActive(false);
        yield return new WaitForSeconds(1);
        Healthbar.SetActive(true);
        yield return new WaitForSeconds(1);
        Healthbar.SetActive(false);
        yield return new WaitForSeconds(1);
        Healthbar.SetActive(true);
        yield return new WaitForSeconds(1);
        Healthbar.SetActive(false);
        yield return new WaitForSeconds(1);
        Healthbar.SetActive(true);
        yield return new WaitForSeconds(1);
        Healthbar.SetActive(false);
        yield return new WaitForSeconds(1);
        Healthbar.SetActive(true);
        yield return new WaitForSeconds(1);
        Healthbar.SetActive(false);
        yield return new WaitForSeconds(1);
        Healthbar.SetActive(true);
        healthAndHunger[0].SetActive(false);
        healthAndHunger[1].SetActive(true);
        hungerBar.SetActive(false);
        yield return new WaitForSeconds(1);
        hungerBar.SetActive(true);
        yield return new WaitForSeconds(1);
        hungerBar.SetActive(false);
        yield return new WaitForSeconds(1);
        hungerBar.SetActive(true);
        yield return new WaitForSeconds(1);
        hungerBar.SetActive(false);
        yield return new WaitForSeconds(1);
        hungerBar.SetActive(true);
        yield return new WaitForSeconds(1);
        hungerBar.SetActive(false);
        yield return new WaitForSeconds(1);
        hungerBar.SetActive(true);
        yield return new WaitForSeconds(1);
        hungerBar.SetActive(false);
        yield return new WaitForSeconds(1);
        hungerBar.SetActive(true);
        healthAndHunger[1].SetActive(false);
        healthAndHunger[2].SetActive(true);
        yield return new WaitForSeconds(4);
        healthAndHunger[2].SetActive(false);
        tutorialBackground.SetActive(false);

    }


}