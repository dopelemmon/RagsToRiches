using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodPrice : MonoBehaviour
{
    public GameObject main;
    public GameObject textCautionbackGround;
    public GameObject textCaution;
    public GameObject burgerButton;
    public GameObject chickenButton;
    public GameObject spagchickButton;
    public GameObject nuggetsButton;
    public int burgerP;
    public int chickenP;
    public int chickenspagP;
    public int nuggetsP;
    public Text burger;
    public Text chicken;
    public Text chickenS;
    public Text nugget;

    public int Totalallinall;
    public Text allinall;

   

    //burger button expense list
    public Text BurgerPcs;
    public int BurgerPiece;
    public Text BurgerPrc;
    public int BurgerPrice;
    public int BurgerPriceTotal;
    public GameObject Burgerexpense;

    //chicken button expense list
    public Text ChickenPcs;
    public int ChickenPiece;
    public Text ChickenPrc;
    public int ChickenPrice;
    public int ChickenPriceTotal;
    public GameObject Chickenexpense;

    //spagchick button expense list
    public Text SpagChickPcs;
    public int SpagChickPiece;
    public Text SpagChickPrc;
    public int SpagChickPrice;
    public int SpagChickPriceTotal;
    public GameObject Spagchickexpense;

    //nuggets button expense list
    public Text NuggetsPcs;
    public int NuggetsPiece;
    public Text NuggetsPrc;
    public int NuggetsPrice;
    public int NuggetsPriceTotal;
    public GameObject Nuggetsexpense;
    // Start is called before the first frame update
    void Start()
    {

        
        burgerP = 70;
        chickenP = 90;
        chickenspagP = 100;
        nuggetsP = 120;
        




        burger.text = "₱ " + burgerP.ToString();
        chicken.text = "₱ " + chickenP.ToString();
        chickenS.text = "₱ " + chickenspagP.ToString();
        nugget.text = "₱ " + nuggetsP.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Totalallinall = BurgerPriceTotal + ChickenPriceTotal + SpagChickPriceTotal + NuggetsPriceTotal;
        allinall.text = "₱ " + Totalallinall.ToString();

    }

    public void buyBurger()
    {
        if (main.GetComponent<playerMoney>().money > burgerP)
        {
         //   if (HungerBar.Hunger < HungerBar.maxHunger)
         //   {
                HungerBar.Hunger += 30f;
                main.GetComponent<playerMoney>().subtractMoney(burgerP);
                BurgerPiece++;
                BurgerPcs.text = BurgerPiece.ToString();
                BurgerprcUpdate();
                Burgerexpense.SetActive(true);
         //   }

          /*  else
            {
                openPriceCaution();
                burgerButton.SetActive(true);
            }*/
        }
        

    }
    public void forcebuyBurger()
    {
        if (main.GetComponent<playerMoney>().money > burgerP)
        {
            if (HungerBar.Hunger < HungerBar.maxHunger)
            {
                HungerBar.Hunger += 30f;

            }
            main.GetComponent<playerMoney>().subtractMoney(burgerP);
            BurgerPiece++;
            BurgerPcs.text = BurgerPiece.ToString();
            BurgerprcUpdate();
            Burgerexpense.SetActive(true);


        }
    }
    public void buyChicken()
    {
        if (main.GetComponent<playerMoney>().money > chickenP)
        {
       //     if (HungerBar.Hunger < HungerBar.maxHunger)
         //   {
                HungerBar.Hunger += 50f;
                main.GetComponent<playerMoney>().subtractMoney(chickenP);
                ChickenPiece++;
                ChickenPcs.text = ChickenPiece.ToString();
                ChickenprcUpdate();
                Chickenexpense.SetActive(true);
            }
        /*    else
            {
                openPriceCaution();
                chickenButton.SetActive(true);
            }*/


    }

    

    public void forcebuyChicken()
    {
        if (main.GetComponent<playerMoney>().money > chickenP)
        {
            if (HungerBar.Hunger < HungerBar.maxHunger)
            {
                HungerBar.Hunger += 50f;
            }
            main.GetComponent<playerMoney>().subtractMoney(chickenP);
            ChickenPiece++;
            ChickenPcs.text = ChickenPiece.ToString();
            ChickenprcUpdate();
            Chickenexpense.SetActive(true);

        }
    }
    public void buySpagChick()
    {
        if (main.GetComponent<playerMoney>().money > chickenspagP)
        {
       //     if (HungerBar.Hunger < HungerBar.maxHunger)
        //    {
                HungerBar.Hunger += 50f;
                main.GetComponent<playerMoney>().subtractMoney(chickenspagP);
                SpagChickPiece++;
                SpagChickPcs.text = SpagChickPiece.ToString();
                SpagChickprcUpdate();
                Spagchickexpense.SetActive(true);
      //      }
          /*  else
            {
                openPriceCaution();
                spagchickButton.SetActive(true);
            } */

        }
    }

    public void forcebuySpagChick()
    {
        if (main.GetComponent<playerMoney>().money > chickenspagP)
        {
            if (HungerBar.Hunger < HungerBar.maxHunger)
            {
                HungerBar.Hunger += 50f;
            }
            main.GetComponent<playerMoney>().subtractMoney(chickenspagP);
            SpagChickPiece++;
            SpagChickPcs.text = SpagChickPiece.ToString();
            SpagChickprcUpdate();
            Spagchickexpense.SetActive(true);
        }
    }
    public void buyNuggets()
    {
        if (main.GetComponent<playerMoney>().money > nuggetsP)
        {
          //  if (HungerBar.Hunger < HungerBar.maxHunger)
          //  {
                HungerBar.Hunger += 40f;
                main.GetComponent<playerMoney>().subtractMoney(nuggetsP);
                NuggetsPiece++;
                NuggetsPcs.text = NuggetsPiece.ToString();
                NuggetsprcUpdate();
                Nuggetsexpense.SetActive(true);
        //    }
         /*   else
            {
                openPriceCaution();
                nuggetsButton.SetActive(true);
            } */

        }
    }

    public void forcebuyNuggets()
    {
        if (main.GetComponent<playerMoney>().money > nuggetsP)
        {
            if (HungerBar.Hunger < HungerBar.maxHunger)
            {
                HungerBar.Hunger += 40f;
            }
            main.GetComponent<playerMoney>().subtractMoney(nuggetsP);
            NuggetsPiece++;
            NuggetsPcs.text = NuggetsPiece.ToString();
            NuggetsprcUpdate();
            Nuggetsexpense.SetActive(true);
        }
    }

    public void BurgerprcUpdate()
    {
        BurgerPrice = burgerP;

        BurgerPriceTotal += burgerP;

        BurgerPrc.text = "₱ " + BurgerPriceTotal.ToString();

    }

    public void ChickenprcUpdate()
    {
        ChickenPrice = chickenP;

        ChickenPriceTotal += chickenP;

        ChickenPrc.text = "₱ " + ChickenPriceTotal.ToString();
    }

    public void SpagChickprcUpdate()
    {
        SpagChickPrice = chickenspagP;

        SpagChickPriceTotal += chickenspagP;

        SpagChickPrc.text = "₱ " + SpagChickPriceTotal.ToString();
    }

    public void NuggetsprcUpdate()
    {
        NuggetsPrice = nuggetsP;

        NuggetsPriceTotal += nuggetsP;

        NuggetsPrc.text = "₱ " + NuggetsPriceTotal.ToString();
    }

    public void openPriceCaution()
    {
        textCaution.SetActive(true);
        textCautionbackGround.SetActive(true);
    }

    public void noButton()
    {
        textCaution.SetActive(false);
        textCautionbackGround.SetActive(false);
    }

    public void yesButtonBurger()
        {
            textCaution.SetActive(false);
            textCautionbackGround.SetActive(false);
        }

    public void yesButtonChicken()
    {
        textCaution.SetActive(false);
        textCautionbackGround.SetActive(false);
    }

    public void yesButtonSpagChick()
    {
        textCaution.SetActive(false);
        textCautionbackGround.SetActive(false);
    }

    public void yesButtonNuggets()
    {
        textCaution.SetActive(false);
        textCautionbackGround.SetActive(false);
    }
}
