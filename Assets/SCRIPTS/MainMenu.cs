using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Juego");
    }

    public void QuitGame()
    {
        Debug.Log("Saliendo del juego"); 
        Application.Quit(); 
    }
}