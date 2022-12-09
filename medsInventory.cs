using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class medsInventory : MonoBehaviour
{
    public GameObject playerCash;
    public GameObject medPrices;

    int antibioticPrice;
    int painkillerPrice;
    int vitaminPrice;

    public Text antiBioticqtytxt;
    public Text painKillerqtytxt;
    public Text vitaminsqtytxt;
    public int antiBioticQty;
    public int painKillerQty;
    public int vitaminsQty;
    // Start is called before the first frame update
    void Start()
    {
        antibioticPrice = medPrices.GetComponent<pharmacyScript>().firstAidprice;
        painkillerPrice = medPrices.GetComponent<pharmacyScript>().painkillerPrice;
        vitaminPrice = medPrices.GetComponent<pharmacyScript>().vitaminsPrice;

    }

    // Update is called once per frame
    void Update()
    {
        antiBioticqtytxt.text = "x " + antiBioticQty.ToString();
        painKillerqtytxt.text = "x " + painKillerQty.ToString();
        vitaminsqtytxt.text = "x " + vitaminsQty.ToString();
    }

    public void updateAntibiotic()
    {
        if(playerCash.GetComponent<playerMoney>().money >= antibioticPrice)
        {
            antiBioticQty++;
        }
    }

    public void updatePainkiller()
    {
        if (playerCash.GetComponent<playerMoney>().money >= painkillerPrice)
        {
            painKillerQty++;
        }
    }

    public void updateVitamins()
    {
        if (playerCash.GetComponent<playerMoney>().money >= vitaminPrice)
        {
            vitaminsQty += 30;
        }
    }

    public void useAntibiotic()
    {
        if(antiBioticQty > 0)
        {
            antiBioticQty--;
        }
    }

    public void usePainkiller()
    {
        if(painKillerQty > 0)
        {
            painKillerQty--;
        }
    }

    public void useVitamins()
    {
        if(vitaminsQty > 0)
        {
            vitaminsQty--;
        }
    }
}
