using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apagao : MonoBehaviour
{
    public GameObject luzesCasa;
    public AudioSource interruptor;
    public float tempo;
    public bool contatempo;
    // Start is called before the first frame update
    void Start()
    {
        luzesCasa.SetActive(false);
        tempo += Time.deltaTime;
        contatempo = true;
        interruptor.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(tempo > 3f)
        {
            luzesCasa.SetActive(true);
            interruptor.Play();
            tempo = 0;
            contatempo = false;
        }
        if (tempo < 3f && contatempo == true)
        {
            tempo += Time.deltaTime;

        }
    }
}
