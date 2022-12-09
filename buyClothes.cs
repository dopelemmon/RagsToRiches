using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyClothes : MonoBehaviour
{
    public GameObject main;
    public GameObject clothingStoreUI;
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
                clothingStoreUI.SetActive(true);
                isInteractOpen = true;
                interactUI.SetActive(false);

            }

        }
        else if (isInteractOpen == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                clothingStoreUI.SetActive(false);
                isInteractOpen = false;
                interactUI.SetActive(true);

            }
        }


    }

    void OnTriggerExit(Collider other)
    {
        interactUI.SetActive(false);
        clothingStoreUI.SetActive(false);
    }
}
