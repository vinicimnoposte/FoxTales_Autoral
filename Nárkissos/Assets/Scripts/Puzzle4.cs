using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Puzzle4 : MonoBehaviour
{
    public GameObject glockCena;
    public GameObject glockMao;
    public GameObject lanterna;
    public bool tempo;
    public float timeRemaining = 30;
    public GameObject Timing;
    // Start is called before the first frame update
    void Start()
    {
        Timing.SetActive(false);
        tempo = false;
        glockMao.SetActive(false);
        glockCena.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (tempo)
        {
            
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                 Timing.GetComponent<TextMeshProUGUI>().text = "" + (int) timeRemaining; //o componente texto do objeto do texto e' tempo restante
            }
            else
            {
                SceneManager.LoadScene("Menu");
            }
            if(timeRemaining > 0 && Input.GetKeyDown(KeyCode.Mouse0))
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
     void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && glockMao.activeInHierarchy == false)
        {
            Timing.SetActive(true);
            tempo = true;
            glockMao.SetActive(true);
            glockCena.SetActive(false);
            lanterna.SetActive(false);
        }
    }
}
