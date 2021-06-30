using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diary : MonoBehaviour
{

    public GameObject[] paginas; //array para as paginas do diario
    public int pagina_atual; //em qual pagina do diario o jogador esta
    public int Permitido;

    public AudioSource somFolha;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Permitido = 1;
        pagina_atual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Avanca();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Volta();
        }
        for (int i = 0; i<paginas.Length; i++)
        {
            paginas[i].SetActive(i == pagina_atual);
        }
        if(Permitido == 2)
        {
            Permitido++;
        }
    }

    public void Avanca()
    {
        if (pagina_atual < paginas.Length)
        {
            if (pagina_atual < Permitido)
            {
                pagina_atual++;
                somFolha.Play();
            }
        }

    }
    public void Volta()
    {
        
        if (pagina_atual > 0)
        {
            pagina_atual--;
            somFolha.Play();
        }
    }

}
