using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject mensagemTutorial1;
    public GameObject itensCarro;
   // public float tempo;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        mensagemTutorial1.SetActive(true);
        if(itensCarro.activeInHierarchy == false)
        {
            mensagemTutorial1.SetActive(false);
        }
        // tempo += Time.deltaTime;

    }
    public void OnTriggerExit(Collider other)
    {
        mensagemTutorial1.SetActive(false);
    }

}
