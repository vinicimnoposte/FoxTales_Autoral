using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookBehaviour : MonoBehaviour
{
    public GameObject notebook; // o notebook
    bool noteOn; // verifica se o bloco de notas esta ativo ou nao
    public GameObject Jogador; // o jogador
    

    // Start is called before the first frame update
    void Start()
    {
        notebook.SetActive(false); //desativa o bloco de notas no inicio do jogo
        noteOn = false; //declara o bloco como desligado
        Jogador = GameObject.FindGameObjectWithTag("Player"); //os objetos tem constante acesso a posicao do jogador
    }

    // Update is called once per frame
    void Update()
    {
        
        if (noteOn == false && Input.GetKeyDown("t")) // verifica se o bloco de notas esta desligado e se o botao para ligar foi apertado
        {
            notebook.SetActive(true); //ativa o bloco de notas
            noteOn = true; //declara o bloco de notas como ativo
            Jogador.GetComponent<ItemGrab>().item.SetActive(false);   //declara os tres itens da HUD como falsos, para apenas o bloco de notas aparecer
            Jogador.GetComponent<ItemGrab>().item2s.SetActive(false); //declara os tres itens da HUD como falsos, para apenas o bloco de notas aparecer
            Jogador.GetComponent<ItemGrab>().item3s.SetActive(false); //declara os tres itens da HUD como falsos, para apenas o bloco de notas aparecer

        }
        else if(noteOn == true && Input.GetKeyDown("t")) //verifica se o bloco de notas esta ligado e se o botao de desligar foi apertado
        {
            notebook.SetActive(false); //desativa o bloco de notas
            noteOn = false; //declara o bloco de notas como desativo
            ControlaHud(); //ativa os itens da HUD
        }
    }

    public void ControlaHud() 
    {
        switch (Jogador.GetComponent<ItemGrab>().itemHud) { //ativa os itens na HUD sequencialmente

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
