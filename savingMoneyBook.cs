using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savingMoneyBook : MonoBehaviour
{
    public GameObject bookShelve;
    public GameObject wholeSavingBook;
    public GameObject cover;
    public GameObject page1;
    public GameObject page2;
    public GameObject nextButton;
    public GameObject prevButton;
    public GameObject closeCoverButton;
    public GameObject closeBodyButton;

    public GameObject realEstateBook;
    public GameObject[] realEstateContent;

    bool isPage1Active = false;
    bool isPage2Active = false;

    public bool realEstateBookisOpen;
    public bool savingMoneyBookisOpen;
    

    public int increment;
    // Start is called before the first frame update
    void Start()
    {
        realEstateBookisOpen = false;
        savingMoneyBookisOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (savingMoneyBookisOpen)
        {
            if (increment == 1)
            {
                if (isPage1Active == false)
                {
                    page1.SetActive(true);
                    isPage1Active = true;

                    page2.SetActive(false);
                    isPage2Active = false;
                }
            }
            else if (increment == 2)
            {
                if (isPage2Active == false)
                {
                    page2.SetActive(true);
                    isPage2Active = true;

                    page1.SetActive(false);
                    isPage1Active = false;
                }
            }
        }

        else if (realEstateBookisOpen == true)
        {
            if(increment == 11)
            {
                
                realEstateContent[1].SetActive(true);
                realEstateContent[2].SetActive(false);
                realEstateContent[3].SetActive(false);
                realEstateContent[6].SetActive(true);
                realEstateContent[7].SetActive(true);

            }
            else if (increment == 12)
            {
                realEstateContent[2].SetActive(true);
                realEstateContent[1].SetActive(false);               
                realEstateContent[3].SetActive(false);
                realEstateContent[6].SetActive(true);
                realEstateContent[7].SetActive(true);
            }
            else if (increment == 13)
            {
                realEstateContent[3].SetActive(true);
                realEstateContent[1].SetActive(false);
                realEstateContent[2].SetActive(false);
                realEstateContent[6].SetActive(true);
                realEstateContent[7].SetActive(true);
            }
        }
    }

    public void nextPage()
    {
        if (savingMoneyBookisOpen)
        {
            if (increment >= 1 && increment < 2)
            {
                increment++;
            }
        }

        else if (realEstateBookisOpen)
        {
            if(increment >= 11 && increment < 13)
            {
                increment++;
            }
        }
        
    }

    public void prevPage()
    {
        if (savingMoneyBookisOpen)
        {
            if (increment <= 2 && increment > 1)
            {
                increment--;

            }
        }

        if (realEstateBookisOpen)
        {
            if(increment <= 13 && increment > 11)
            {
                increment--;
            }
        }
    }

    public void openBook()
    {
        cover.SetActive(false);
        closeCoverButton.SetActive(false);
        closeBodyButton.SetActive(true);
        nextButton.SetActive(true);
        prevButton.SetActive(true);
        page1.SetActive(true);
        increment++;
        savingMoneyBookisOpen = true;
    }

    public void openRealEstateContent()
    {
        realEstateContent[4].SetActive(false);//CLOSE COVER BUTTON
        realEstateContent[0].SetActive(false);
        realEstateContent[5].SetActive(true);
        realEstateContent[1].SetActive(true);
        realEstateBookisOpen = true;
        increment = 11;
    }

    public void closeBook()
    {
        if(increment ==  1)
        {
            page1.SetActive(false);
            isPage1Active = false;
        }
        else if(increment == 2)
        {
            page2.SetActive(false);
            isPage2Active = false;
        }

        increment = 0;
        closeBodyButton.SetActive(false);
        nextButton.SetActive(false);
        prevButton.SetActive(false);
        closeCoverButton.SetActive(true);
        cover.SetActive(true);
    }

    public void openSavingMoneyBook()
    {
        wholeSavingBook.SetActive(true);
        cover.SetActive(true);
        bookShelve.SetActive(true);
        closeCoverButton.SetActive(true);


    }

    public void openSavingContent()
    {
        savingMoneyBookisOpen = true;
        increment = 1;
    }

    public void openRealEstateBook()
    {
        realEstateBook.SetActive(true);
        realEstateContent[0].SetActive(true); //BOOK COVER
        realEstateContent[4].SetActive(true);
        nextButton.SetActive(false);
        prevButton.SetActive(false);
        realEstateContent[5].SetActive(false);
        realEstateContent[6].SetActive(false);
        realEstateContent[7].SetActive(false);
 


    }

    public void closeBookSaving()
    {
        cover.SetActive(false);
        bookShelve.SetActive(true);
        closeCoverButton.SetActive(false);
        savingMoneyBookisOpen = false;

    }

    public void closeRealEstateContent()
    {
        realEstateContent[0].SetActive(true);
        realEstateContent[1].SetActive(false);
        realEstateContent[2].SetActive(false);
        realEstateContent[3].SetActive(false);
        realEstateContent[4].SetActive(true);
        realEstateContent[5].SetActive(false);
        realEstateContent[6].SetActive(false);
        realEstateContent[7].SetActive(false);
        nextButton.SetActive(false);
        prevButton.SetActive(false);

        realEstateBookisOpen = false;
        savingMoneyBookisOpen = false;
        increment = 1;

    }

    public void closeRealEstateCover()
    {
        realEstateContent[0].SetActive(false);
        realEstateContent[4].SetActive(false);

        savingMoneyBookisOpen = false;
        realEstateBookisOpen = false;
    }
}
