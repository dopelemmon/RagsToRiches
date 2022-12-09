using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class playerMoney : MonoBehaviour
{

    public int money;
    public TMP_Text moneyText;
    bool issavedGame;
    // Start is called before the first frame update
    void Start()
    {
        issavedGame = saveGame.isGameSaved;
        if (issavedGame == true)
        {
            money = saveGame.moneyofPlayer;
        }
        else
        {
            money = 500;
        }
        moneyText.text = "₱ " + money.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        issavedGame = saveGame.isGameSaved;
    }

    public void addMoney(int moneyToAdd)
    {
        money += moneyToAdd;
        moneyText.text = "₱ " + money.ToString();
    }
    public void subtractMoney(int moneyToSubtract)
    {
        if (money - moneyToSubtract < 0)
        {
            Debug.Log("We don't have enough money");
        }
        else
        {
            money -= moneyToSubtract;
            moneyText.text = "₱ " + money.ToString();
        }
    }
}
