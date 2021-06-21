using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    public GameObject toy;
    public GameObject bulb;
    public GameObject item1;
    public GameObject item2;
    public GameObject manequim;


    public bool isToy = false;
    public bool isBulb = false;
    public bool itemHUD = false;
    public bool item2HUD = false;
    void Start()
    {
        toy.SetActive(false);
        bulb.SetActive(false);
        manequim.SetActive(false);
        item1.SetActive(false);
        item2.SetActive(false);
    }
    void Update()
    {
        if (item1.activeSelf == true)
        {
            itemHUD = true;
        }
        if (item2.activeSelf == true)
        {
            item2HUD = true;
        }
        if (isToy == false && itemHUD == true && Input.GetKeyDown("e"))
        {
            toy.SetActive(true);
            isToy = true;
            item1.SetActive(false);
        }
        if (isBulb == false && item2HUD == true && Input.GetKeyDown("e"))
        {
            bulb.SetActive(true);
            isBulb = true;
            item2.SetActive(false);
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (isToy == false && itemHUD == true && Input.GetKeyDown("e"))
        {
            toy.SetActive(true);
            item1.SetActive(false);
            isToy = true;
        }
        if (isBulb == false && item2HUD == true && Input.GetKeyDown("e"))
        {
            bulb.SetActive(true);
            item2.SetActive(false);
            isBulb = true;
            manequim.SetActive(true);
        }
    }
   
}
