using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaMenu()
    {
        SceneManager.LoadScene("JUEGO");
    }

    public void CargarNivel1(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }

    public void SalirSalir()
    {
        Application.Quit();
    }

}