using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2 : MonoBehaviour
{
    public GameObject itens;
    public GameObject itensCarro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            itens.SetActive(true);

            itensCarro.SetActive(false);
        }
        
    }
}
