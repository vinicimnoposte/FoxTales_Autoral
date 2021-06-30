using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public GameObject trigger;
    public GameObject lanternaMao;


    public bool isPlay = false;

    public AudioSource playSound;
     void Update()
     {

     }

    void OnTriggerStay(Collider other)
    {
        if (lanternaMao.activeInHierarchy == true && isPlay == false)
        {
            playSound.Play();
            isPlay = true;
        }

    }



}
