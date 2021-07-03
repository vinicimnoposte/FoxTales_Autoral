using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apagao : MonoBehaviour
{
    public GameObject luzesCasa;
    public AudioSource interruptor;
    public float tempo;
    public bool contatempo;
    public bool podeTocar = true;
    public GameObject dialogEquip;
    public GameObject equips;
    // Start is called before the first frame update
    void Start()
    {
      //  luzesCasa.SetActive(false);
        tempo += Time.deltaTime;
        contatempo = true;
       // equips.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(tempo > 3f && contatempo == true)
        {
            luzesCasa.SetActive(false);
 
           // equips.SetActive(false);
            if (luzesCasa.activeSelf == false && podeTocar == true)
            {
                interruptor.Play();
                podeTocar = false;
            }
        }
        if (tempo <= 6f && contatempo == true)
        {
            tempo += Time.deltaTime;
        }
        if(tempo > 6f)
        {
            tempo += Time.deltaTime;
            luzesCasa.SetActive(true);
            dialogEquip.SetActive(true);
            if(tempo > 9f)
            {
                dialogEquip.SetActive(false);
                tempo = 0;
                contatempo = false;
                interruptor.Play();
            }


        }
    }
}
