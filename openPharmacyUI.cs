using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openPharmacyUI : MonoBehaviour
{
    public GameObject mainPlayer;

    public GameObject pharmacyStoreUI;
    public GameObject interactUI;

    bool isInteractOpen = false;
    void OnTriggerEnter(Collider other)
    {
        interactUI.SetActive(true);
    }

    void OnTriggerStay(Collider other)
    {

        if (isInteractOpen == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pharmacyStoreUI.SetActive(true);
                isInteractOpen = true;
                interactUI.SetActive(false);

            }

        }
        else if (isInteractOpen == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pharmacyStoreUI.SetActive(false);
                isInteractOpen = false;
                interactUI.SetActive(true);

            }
        }


    }

    void OnTriggerExit(Collider other)
    {
        interactUI.SetActive(false);
        pharmacyStoreUI.SetActive(false);
    }

}
