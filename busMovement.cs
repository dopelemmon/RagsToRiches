using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class busMovement : MonoBehaviour
{
    public GameObject movingBus;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movingBus.transform.Translate(0, 0, 2f * Time.deltaTime);
    }
}
