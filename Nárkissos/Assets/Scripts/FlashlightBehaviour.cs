using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightBehaviour : MonoBehaviour
{
    public AudioSource clickSound;

    public GameObject flashlight; //a lanterna
    bool flashOn; //verifica se a lanterna esta ligada ou nao
    // Start is called before the first frame update
    void Start()
    {
        flashlight.SetActive(false); //desativa a lanterna quando o jogo inicia
        flashOn = false; //declara a lanterna como desligada
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && flashOn == false) //verifica se o jogador apertou o botao de ligar a lanterna
        {
            flashlight.SetActive(true); //liga a lanterna
            flashOn = true; // declara a lanterna como ligada
            clickSound.Play();
        }
        else if(Input.GetKeyDown("space") && flashOn == true) // verifica se o jogador apertou o botao de desligar a lanterna
        {
             flashlight.SetActive(false); //desliga a lanterna
             flashOn = false; //declara a lanterna como desligada
             clickSound.Play();
        }
    }
}
