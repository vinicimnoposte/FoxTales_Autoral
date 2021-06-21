using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightBehaviour : MonoBehaviour
{

    public GameObject flashlight;
    bool flashOn;
    // Start is called before the first frame update
    void Start()
    {
        flashlight.SetActive(false);
        flashOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && flashOn == false)
        {
            flashlight.SetActive(true);
            flashOn = true;
        }
        else if(Input.GetKeyDown("space") && flashOn == true)
        {
             flashlight.SetActive(false);
             flashOn = false;
        }
    }
}
