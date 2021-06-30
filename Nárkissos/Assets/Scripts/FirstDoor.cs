using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstDoor : MonoBehaviour
{
    

     void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(1);
        }
    }
}
