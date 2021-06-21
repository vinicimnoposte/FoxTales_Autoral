using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBeahvior : MonoBehaviour
{
    public GameObject Jogador;
    public int ItemAtual;
    // Start is called before the first frame update
    void Start()
    {
        Jogador = GameObject.FindGameObjectWithTag("Player");
    }


    public void DoSomething()
    {
        if (ItemAtual == Jogador.GetComponent<ItemGrab>().qualItem)
        {
            Jogador.GetComponent<ItemGrab>().HUD();

            Jogador.GetComponent<ItemGrab>().AtivaProximoItem();

            Destroy(gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
