using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diary : MonoBehaviour
{

    public GameObject[] paginas; //array para as paginas do diario
    public int pagina_atual; //em qual pagina do diario o jogador esta
    public int Permitido;
    public GameObject verificaPuzzle2;
    public GameObject ensinaDiario;
    public float contaTempo;

    public AudioSource somFolha;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Permitido = 1;
        pagina_atual = 0;
        ensinaDiario.SetActive(true);
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
        if(Permitido == 2 && verificaPuzzle2.activeInHierarchy == false)
        {
            Permitido = 3;
        }
        if (ensinaDiario.activeInHierarchy == true)
        {
            if (contaTempo < 3f)
            {
                contaTempo += Time.deltaTime;
            }
            if (contaTempo > 3f || Input.GetKeyDown(KeyCode.T))
            {
                ensinaDiario.SetActive(false);
                contaTempo = 0;
            }
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
