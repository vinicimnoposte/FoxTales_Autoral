using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBeahvior : MonoBehaviour
{
    public GameObject Jogador; //o jogador
    public int ItemAtual; //em qual item o jogador esta
    // Start is called before the first frame update
    void Start()
    {
        Jogador = GameObject.FindGameObjectWithTag("Player"); //os itens tem acesso constante a posicao do jogador
    }


    public void DoSomething()
    {
        if (ItemAtual == Jogador.GetComponent<ItemGrab>().qualItem) //ativa o item atual que o jogador coletou
        {
            Jogador.GetComponent<ItemGrab>().HUD();

            Jogador.GetComponent<ItemGrab>().AtivaProximoItem();



        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
