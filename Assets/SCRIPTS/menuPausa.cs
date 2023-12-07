using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menuPausa : MonoBehaviour
{

    [SerializeField] private GameObject BotonPausa;
    [SerializeField] private GameObject MenuPausa;

    public void Pausa()
    {
        Time.timeScale = 1f;
        BotonPausa.SetActive(false);
        MenuPausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        BotonPausa.SetActive(true);
        MenuPausa.SetActive(false);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene (SceneManager.GetActiveScene().name);

    }
   
   
        public void Salir ()
        {
            SceneManager.LoadScene("MenuPrincipal");
        }

    
}