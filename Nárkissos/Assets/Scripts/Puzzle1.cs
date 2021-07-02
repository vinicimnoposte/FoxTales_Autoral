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
    public GameObject chave;
    public GameObject gavetaAberta;
    public GameObject gavetaFechada;
    public GameObject lanternaGaveta;
    public GameObject lanternaMao;
    public GameObject luzesCasa;
    public GameObject dica;
    public GameObject dica2;
    public GameObject dicaDiario;

    public AudioSource toyMus;

    public bool isFlash = false;
    public bool isToy = false;
    public bool isBulb = false;
    public bool itemHUD = false;
    public bool item2HUD = false;

    public float contaTempo;
    void Start()
    {
        toy.SetActive(false);
        bulb.SetActive(false);
        manequim.SetActive(false);
        item1.SetActive(false);
        item2.SetActive(false);
        gavetaFechada.SetActive(true);
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
        if (isToy == false)
        {
            chave.SetActive(false);
        }
        if (dica.activeInHierarchy == true)
        {
            if (contaTempo < 3f)
            {
                contaTempo += Time.deltaTime;
            }
            if (contaTempo > 3f)
            {
                dica.SetActive(false);
                dica2.SetActive(false);
                contaTempo = 0;
            }
        }
        if(dica2.activeInHierarchy == true)
        {
            if (contaTempo < 3f)
            {
                contaTempo += Time.deltaTime;
            }
            if (contaTempo > 3f || bulb.activeInHierarchy == true)
            {
                dica2.SetActive(false);
                contaTempo = 0;
            }
        }
        if(dicaDiario.activeInHierarchy == true)
        {
            if (contaTempo < 3f)
            {
                contaTempo += Time.deltaTime;
            }
            if (contaTempo > 3f || Input.GetKeyDown(KeyCode.T))
            {
                dicaDiario.SetActive(false);
                contaTempo = 0;
            }
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if(isToy == false && itemHUD == false && Input.GetKeyDown(KeyCode.E))
        {
            dica.SetActive(true);
        }
        if (isToy == false && itemHUD == true && Input.GetKeyDown("e"))
        {
            toy.SetActive(true);
            toyMus.Play();
            item1.SetActive(false);
            isToy = true;
        }
        if(isToy == true && Input.GetKeyDown(KeyCode.E) && isBulb == false)
        {
            dica2.SetActive(true);
        }
        if (isBulb == false && item2HUD == true && Input.GetKeyDown("e"))
        {
            bulb.SetActive(true);
            toyMus.Stop();
            item2.SetActive(false);
            isBulb = true;
            manequim.SetActive(true);
            chave.SetActive(true);
            gavetaFechada.SetActive(false);
            gavetaAberta.SetActive(true);

        }
        if (gavetaAberta.activeSelf == true && Input.GetKeyDown("e"))
        {
            isFlash = true;
            if (isFlash == true && Input.GetKeyDown("e"))
            {
                lanternaMao.SetActive(true);
                lanternaGaveta.SetActive(false);
            }
            if (lanternaMao.activeSelf == true)
            {
                luzesCasa.SetActive(false);
            }
            dicaDiario.SetActive(true);
        }
    } 
}
