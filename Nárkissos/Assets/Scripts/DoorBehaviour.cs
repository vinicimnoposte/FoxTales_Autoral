using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public GameObject chave;
    public GameObject porta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(chave.activeSelf == true && Input.GetKeyDown(KeyCode.E))
        {
            porta.SetActive(false);
        }
        if(porta.activeSelf == false && chave.activeSelf == true)
        {
            chave.SetActive(false);
        }
        
    }
}
