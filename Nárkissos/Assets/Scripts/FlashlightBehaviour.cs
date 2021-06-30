using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightBehaviour : MonoBehaviour
{
    public AudioSource clickSound;

    public float intensidade;

    public GameObject flashlight; //a lanterna
    bool flashOn; //verifica se a lanterna esta ligada ou nao
    // Start is called before the first frame update
    void Start()
    {
        flashlight.SetActive(false); //desativa a lanterna quando o jogo inicia
        flashOn = false; //declara a lanterna como desligada
    }
     void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {

            float dist = Vector3.Distance(hit.collider.gameObject.transform.position, transform.position); //distancia entre a lanterna e o objeto mais proximo a frente da lampada

            //intensidade = Mathf.Lerp(curdist, dist, 0.1f);
            if(dist > 3)       
                flashlight.GetComponent<Light>().intensity = 5;
            if (dist <= 3)
                flashlight.GetComponent<Light>().intensity = 1.5f;
           // Debug.Log(dist);   //quao mais distante o objeto da lampada, mais intensa a luz fica
        } 
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && flashOn == false) //verifica se o jogador apertou o botao de ligar a lanterna
        {
            flashlight.SetActive(true); //liga a lanterna
            flashOn = true; // declara a lanterna como ligada
            clickSound.Play();
        }
        else if (Input.GetKeyDown("space") && flashOn == true) // verifica se o jogador apertou o botao de desligar a lanterna
        {
            flashlight.SetActive(false); //desliga a lanterna
            flashOn = false; //declara a lanterna como desligada
            clickSound.Play();
        }   
    }
}
