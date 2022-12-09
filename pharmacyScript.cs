using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pharmacyScript : MonoBehaviour
{
    public GameObject main;

    //EXPENSE LIST
    //qty
    public Text firstAidQtytxt;
    public Text painKillerQtytxt;
    public Text vitaminsQtytxt;
    
    public int firstAidQty;
    public int painkillerQty;
    public int vitaminsQty;

    //totalprice
    public Text totalFirstAidpricetxt;
    public Text totalpainKillerPricetxt;
    public Text totalVitaminsPricetxt;

    public int totalFirstAidPrice;
    public int totalpainKillerPrice;
    public int totalVitaminsPrice;

    public Text totalPurchasetxt;
    public int totalPurchase;

    public Text firstaidPricetxt;
    public Text vitaminsPricetxt;
    public Text painkillerPricetxt;

    public int firstAidprice;
    public int vitaminsPrice;
    public int painkillerPrice;

    // Start is called before the first frame update
    void Start()
    {
 /*Antibiotic*/firstAidprice = 80;
        vitaminsPrice = 300;
        painkillerPrice = 16;

        firstaidPricetxt.text = "₱ " + firstAidprice.ToString();
        vitaminsPricetxt.text = "₱ " + vitaminsPrice.ToString();
        painkillerPricetxt.text = "₱ " + painkillerPrice.ToString();

        


    }

    // Update is called once per frame
    void Update()
    {
        //expenseList
        firstAidQtytxt.text = firstAidQty.ToString();
        painKillerQtytxt.text = painkillerQty.ToString();
        vitaminsQtytxt.text = vitaminsQty.ToString();

        totalFirstAidpricetxt.text = totalFirstAidPrice.ToString();
        totalpainKillerPricetxt.text = totalpainKillerPrice.ToString();
        totalVitaminsPricetxt.text = totalVitaminsPrice.ToString();

        totalPurchase = totalFirstAidPrice + totalpainKillerPrice + totalVitaminsPrice;
        totalPurchasetxt.text = totalPurchase.ToString();


        
    }

    //BUY FIRSTAID
    public void buyFirstAid()
    {
        if (main.GetComponent<playerMoney>().money >= firstAidprice)
        {
            main.GetComponent<playerMoney>().subtractMoney(firstAidprice);
            totalFirstAidPrice += firstAidprice;
            firstAidQty++;
        }
    }

    //BUY VITAMINS
    public void buyVitamins()
    {
        if(main.GetComponent<playerMoney>().money >= vitaminsPrice)
        {
            main.GetComponent<playerMoney>().subtractMoney(vitaminsPrice);
            totalVitaminsPrice += vitaminsPrice;
            vitaminsQty++;
        }
    }

    public void buyPainKiller()
    {
        if(main.GetComponent<playerMoney>().money >= painkillerPrice)
        {
            main.GetComponent<playerMoney>().subtractMoney(painkillerPrice);
            totalpainKillerPrice += painkillerPrice;
            painkillerQty++;

        }
    }
}
