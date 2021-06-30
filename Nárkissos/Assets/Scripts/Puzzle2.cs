using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    public GameObject garrafaHUD;
    public GameObject triggerBox;
    public GameObject radio;
   
    public AudioSource agua;

    // Start is called before the first frame update
    void Start()
    {
        triggerBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerStay(Collider other)
    {
        if (garrafaHUD.activeSelf == true && Input.GetKeyDown("e"))
        {
            triggerBox.SetActive(true);
 


        }
        if (garrafaHUD.activeInHierarchy == true && Input.GetKeyDown(KeyCode.E))
        {
            radio.SetActive(false);
            garrafaHUD.SetActive(false);
            agua.Play();
        }
    }
}
