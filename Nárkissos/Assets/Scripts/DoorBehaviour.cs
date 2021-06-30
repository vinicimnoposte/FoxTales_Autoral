using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public AudioSource openDoor;
    public AudioSource closedDoor;
    public Animator anim;
    public GameObject chave;
    public GameObject porta;
    public GameObject message;
    public float contaTempo;
    public GameObject placeHolder;

    void Update()
    {
        if (message.activeInHierarchy == true)
        {
            if (contaTempo < 3f)
            {
                contaTempo += Time.deltaTime;
            }
            if (contaTempo > 3f)
            {
                message.SetActive(false);
                contaTempo = 0;
            }
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (chave.activeSelf == true && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(portaAbre());
            openDoor.Play();
            placeHolder.SetActive(false);
           // porta.SetActive(false);
        }
        if (placeHolder.activeSelf == false && chave.activeSelf == true)
        {
            chave.SetActive(false);
        }
        if(placeHolder.activeSelf == true && chave.activeSelf == false && Input.GetKeyDown(KeyCode.E))
        {
            contaTempo += Time.deltaTime;
            closedDoor.Play();
            message.SetActive(true);
        }
    }
    IEnumerator portaAbre()
    {
        anim.SetBool("Aberta", true);
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("Aberta", false);
    }


}
