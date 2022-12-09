using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transportationAnim : MonoBehaviour
{
    //APARTMENT
    public GameObject bus;
    public GameObject cameraforbusAnim;
    public GameObject movingBus;
    public GameObject fadeIn;
    public GameObject fadeOut;
    public GameObject transUI;
    public GameObject main;
    public GameObject interact;
    public GameObject miniMap;
    public GameObject healthbarUI;
    public GameObject hungerbarUI;
    public GameObject playermoneyUI;
    public GameObject originalPos;

    //CHURCH
    public GameObject ChurchcameraAnim;
    public GameObject MovingBusAnimChurch;
    public GameObject originalPosChurch;
    public GameObject staticBus;

    public bool isinApartment = true;
    public bool isinChurch;
    public bool isinMall;
    public GameObject originalPositionChurch;

    public void startAnim()
    {
        if (isinApartment == true)
        {
            StartCoroutine(transpoAnim());
        }
        else if (isinChurch == true)
        {
            StartCoroutine(transpoAnimChurch());
        }
        else if (isinMall == true)
        {
            StartCoroutine(transpoAnimMall());
        }
    }

    void Start()
    {
        isinApartment = true;
        isinMall = false;
    }
    IEnumerator transpoAnim()
    {
        interact.SetActive(false);
        transUI.SetActive(false);
        miniMap.SetActive(false);
        healthbarUI.SetActive(false);
        hungerbarUI.SetActive(false);
        playermoneyUI.SetActive(false);
        cameraforbusAnim.SetActive(true);
        main.SetActive(false);
        fadeIn.SetActive(false);
        fadeOut.SetActive(true);       
        yield return new WaitForSeconds(3);
        fadeIn.SetActive(true);
        fadeOut.SetActive(false);
        yield return new WaitForSeconds(1);
        bus.SetActive(false);
        movingBus.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeIn.SetActive(false);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        main.SetActive(true);
        cameraforbusAnim.SetActive(false);
        bus.SetActive(true);
        movingBus.SetActive(false);
        movingBus.transform.position = originalPos.transform.position;
        yield return new WaitForSeconds(1);
        fadeOut.SetActive(false);
        fadeIn.SetActive(true);
        miniMap.SetActive(true);
        healthbarUI.SetActive(true);
        hungerbarUI.SetActive(true);
        playermoneyUI.SetActive(true);

    }

    IEnumerator transpoAnimChurch()
    {
        fadeOut.SetActive(true);
        interact.SetActive(false);
        transUI.SetActive(false);
        miniMap.SetActive(false);
        healthbarUI.SetActive(false);
        hungerbarUI.SetActive(false);
        staticBus.SetActive(false);
        playermoneyUI.SetActive(false);
        ChurchcameraAnim.SetActive(true);
        main.SetActive(false);
        fadeIn.SetActive(false);
        yield return new WaitForSeconds(3);
        fadeIn.SetActive(true);
        fadeOut.SetActive(false);
        
        MovingBusAnimChurch.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeIn.SetActive(false);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        main.SetActive(true);
        ChurchcameraAnim.SetActive(false);
        staticBus.SetActive(true);
        MovingBusAnimChurch.SetActive(false);
        MovingBusAnimChurch.transform.position = originalPositionChurch.transform.position;
        yield return new WaitForSeconds(1);
        fadeOut.SetActive(false);
        miniMap.SetActive(true);
        healthbarUI.SetActive(true);
        hungerbarUI.SetActive(true);
        playermoneyUI.SetActive(true);
        fadeIn.SetActive(true);
        interact.SetActive(false);
        Debug.Log("animation Finish");
    }

    IEnumerator transpoAnimMall()
    {
        fadeOut.SetActive(true);
        interact.SetActive(false);
        transUI.SetActive(false);
        miniMap.SetActive(false);
        healthbarUI.SetActive(false);
        hungerbarUI.SetActive(false);
        playermoneyUI.SetActive(false);
        main.SetActive(false);
        fadeIn.SetActive(false);
        yield return new WaitForSeconds(3);
        
        
        miniMap.SetActive(true);
        healthbarUI.SetActive(true);
        hungerbarUI.SetActive(true);
        playermoneyUI.SetActive(true);
        main.SetActive(true);
        fadeOut.SetActive(false);
        
        
        fadeIn.SetActive(true);

    }
}
