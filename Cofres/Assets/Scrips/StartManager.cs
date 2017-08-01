using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour {

    public void CargarSiguienteNivel(int lvl)
    {
        SceneManager.LoadScene(lvl);
    }

    public void SalirJuego()
    {
        Debug.Log("Salir");
        Application.Quit();
    }

    public void Creditos()
    {
        Application.OpenURL("https://www.agenciahdc.com/");
    }
}
