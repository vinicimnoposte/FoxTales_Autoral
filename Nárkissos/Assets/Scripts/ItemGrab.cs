using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGrab : MonoBehaviour
{
    public GameObject item; // itens na HUD
    public GameObject item2s; // itens na HUD
    public GameObject item3s; // itens na HUD
    public GameObject itemCena; //itens na cena
    public GameObject itemCena2s; //itens na cena
    public GameObject itemCena3s; //itens na cena

    public int qualItem = 0;
    public int itemHud = 0;

    public bool isItem = true;      // verifica se itens cena e hud sao verdadeiros ou nao
    public bool isItem2 = false;    // verifica se itens cena e hud sao verdadeiros ou nao
    public bool isItem3 = false;    // verifica se itens cena e hud sao verdadeiros ou nao
    public bool item1;              // verifica se itens cena e hud sao verdadeiros ou nao
    public bool item2;              // verifica se itens cena e hud sao verdadeiros ou nao
    public bool item3;              // verifica se itens cena e hud sao verdadeiros ou nao



    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp("e") && other.CompareTag("itene")) // verifica se o jogador apertou o botao de usar perto do item
        {

            if (other.GetComponent<ItemBeahvior>()) // verifica quantos itens o jogador pegou e em qual dos itens ele esta atualmente, pois um item so pode ser coletado apos o outro em ordem sequencial
            {
                other.GetComponent<ItemBeahvior>().DoSomething();  

            }
            if (other.GetComponent<Chave>()) //se ele encontra algum o  objeto com o script chave...
            {
                other.GetComponent<Chave>().AtivaDiario();//ate qual pagina voce pode ler
            }

               
        }
    }

    public void HUD()
    {
        switch (itemHud) //ativa os itens pegos na HUD dependendo do item que o jogador pegou
        {
            case 0:

                item.SetActive(true);
                itemCena.SetActive(false);
                itemHud++;
                break;

            case 1:

                item2s.SetActive(true);
                itemCena2s.SetActive(false);
                itemHud++;
                break;

            case 2:

                item3s.SetActive(true);
                itemCena3s.SetActive(false);
                itemHud++;
                break;
        }

    }

    public void AtivaProximoItem() //conta em qual item o jogador esta
    {
        qualItem = qualItem + 1;

    }
}
