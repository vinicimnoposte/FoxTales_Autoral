using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3 : MonoBehaviour
{
    public GameObject armarioEncostado;
    public GameObject armarioEmpurrado;
    public GameObject verifica;
    public GameObject mago;
    public GameObject magoDepois;
    // Start is called before the first frame update
    void Start()
    {
        armarioEmpurrado.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        if(verifica.activeSelf == true && Input.GetKeyDown(KeyCode.E))
        {
            armarioEmpurrado.SetActive(true);
            armarioEncostado.SetActive(false);
            mago.SetActive(false);
            magoDepois.SetActive(true);
        }
    }
}
