using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefMovement : MonoBehaviour
{
    public GameObject mainChar;
    public GameObject npc;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mainChar.transform.Translate(0, 0, 4f * Time.deltaTime);
    }
}
