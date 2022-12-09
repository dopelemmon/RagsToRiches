using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class consoleAddMoney : MonoBehaviour
{
    

    public GameObject main;
    public Text inputCommand;

    public int addMoney;

    public GameObject consoleOpen;

    bool isconsoleOpen;
    

    void Awake()
    {
        isconsoleOpen = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        consoleOpen.SetActive(true);

        isconsoleOpen = true;
    }


    void OnTriggerExit(Collider other)
    {
        consoleOpen.SetActive(false);
        isconsoleOpen = false;
    }

    public void moneyadd()
    {
        bool success = int.TryParse(inputCommand.text, out addMoney);
        if (isconsoleOpen == true)
        {
            main.GetComponent<playerMoney>().addMoney(addMoney);
        }
    }
}
