using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaEquip : MonoBehaviour
{
    public GameObject lanterna;
    public GameObject glock;
    public GameObject avisoTiro;
    public GameObject itens;
    public GameObject msgAlternaEquip;
    public GameObject verifica;
    public int contaMsg = 0;
    public bool shotWarning = false;
    public bool equipTut = false;
    public float tempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if (verifica.activeInHierarchy == true)
       // {
       //     msgAlternaEquip.SetActive(true);
       //     
       // }
       // else
       // {
       //     msgAlternaEquip.SetActive(false);
       // }
       // if (glock.activeInHierarchy == true)
       // {
       //     verifica.SetActive(true);
       // }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            glock.SetActive(true);
            lanterna.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            lanterna.SetActive(true);
            glock.SetActive(false);
            

        }
        if (lanterna.activeSelf == true)
        {
            msgAlternaEquip.SetActive(true);
        }
        else if (glock.activeSelf == true)
        {
            msgAlternaEquip.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            avisoTiro.SetActive(true);       
            shotWarning = true;  
            
        }
        if (shotWarning == true)
            tempo += Time.deltaTime;
        if(tempo > 3f)
        {
            avisoTiro.SetActive(false);
            shotWarning = false;
            tempo = 0;
        }
    }
}
