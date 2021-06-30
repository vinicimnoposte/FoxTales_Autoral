using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Update()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    public void QuitGame()
    {
        Debug.Log("SAIU!!!");
        Application.Quit();
    }
}
