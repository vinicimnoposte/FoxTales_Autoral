using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGrab : MonoBehaviour
{
    public GameObject item;
    public GameObject item2s;
    public GameObject item3s;
    public GameObject itemCena;
    public GameObject itemCena2s;
    public GameObject itemCena3s;
    public int qualItem = 0;
    public int itemHud = 0;

    public bool isItem = true;
    public bool isItem2 = false;
    public bool isItem3 = false;
    public bool item1;
    public bool item2;
    public bool item3;



    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp("e") && other.CompareTag("itene"))
        {

            if (other.GetComponent<ItemBeahvior>())
            {
                other.GetComponent<ItemBeahvior>().DoSomething();

            }


               
        }
    }

    public void HUD()
    {
        switch (itemHud)
        {
            case 0:

                item.SetActive(true);
                itemHud++;
                break;

            case 1:

                item2s.SetActive(true);
                itemHud++;
                break;

            case 2:

                item3s.SetActive(true);
                itemHud++;
                break;
        }

    }

    public void AtivaProximoItem()
    {
        qualItem = qualItem + 1;

    }
}
