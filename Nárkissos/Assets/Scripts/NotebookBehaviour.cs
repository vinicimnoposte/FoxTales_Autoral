using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookBehaviour : MonoBehaviour
{
    public GameObject notebook;
    bool noteOn;
    public GameObject Jogador;
    

    // Start is called before the first frame update
    void Start()
    {
        notebook.SetActive(false);
        noteOn = false;
        Jogador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (noteOn == false && Input.GetKeyDown("t")) 
        {
            notebook.SetActive(true);
            noteOn = true;
            Jogador.GetComponent<ItemGrab>().item.SetActive(false);
            Jogador.GetComponent<ItemGrab>().item2s.SetActive(false);
            Jogador.GetComponent<ItemGrab>().item3s.SetActive(false);

        }
        else if(noteOn == true && Input.GetKeyDown("t"))
        {
            notebook.SetActive(false);
            noteOn = false;
            ControlaHud();
        }
    }

    public void ControlaHud()
    {
        switch (Jogador.GetComponent<ItemGrab>().itemHud) {

            case 0:

                break;

            case 1:
                Jogador.GetComponent<ItemGrab>().item.SetActive(true);
                break;

            case 2:
                Jogador.GetComponent<ItemGrab>().item.SetActive(true);
                Jogador.GetComponent<ItemGrab>().item2s.SetActive(true);
                break;

            case 3:
                Jogador.GetComponent<ItemGrab>().item.SetActive(true);
                Jogador.GetComponent<ItemGrab>().item2s.SetActive(true);
                Jogador.GetComponent<ItemGrab>().item3s.SetActive(true);
                break;

        }


    }
}
