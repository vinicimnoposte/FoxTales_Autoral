using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonDoorBhvr : MonoBehaviour
{
    public GameObject porta;
    public bool fechada;
    // Start is called before the first frame update
    void Start()
    {
        
        fechada = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if(fechada == true && Input.GetKeyDown(KeyCode.E)) //porta abre
        {
            porta.SetActive(false);
            fechada = false;
        }

      //  if (fechada == false && Input.GetKeyDown(KeyCode.E)) //porta fecha
      //  {
      //      porta.SetActive(true);
      //      fechada = true;
      //  }

    }
}
