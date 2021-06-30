using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBhvr : MonoBehaviour
{
    public GameObject manequins;
    public GameObject porta;
    public GameObject mago;


    // Start is called before the first frame update
    void Start()
    {
        manequins.SetActive(false);
        porta.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {   
            porta.SetActive(false);
            manequins.SetActive(true);
            mago.SetActive(false);
    }
}
