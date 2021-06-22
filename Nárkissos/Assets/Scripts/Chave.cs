using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave : MonoBehaviour
{
    public GameObject chaveHUD;
    public GameObject CanvasMenu;
    // Start is called before the first frame update
    void Start()
    {
        CanvasMenu = GameObject.FindGameObjectWithTag("Canvas"); //encontra o objeto com a tag canvas
    }

    public void AtivaDiario()
    {
        CanvasMenu.GetComponent<Diary>().Permitido++; //ate qual pagina do diario voce pode ler
        Destroy(gameObject);
        chaveHUD.SetActive(true);

    }
       
    // Update is called once per frame
    void Update()
    {
        
    }
}
