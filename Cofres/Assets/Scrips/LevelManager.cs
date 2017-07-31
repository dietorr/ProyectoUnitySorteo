using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    //public int escena;

    public void cambiarNivel(int escena)
    {
        SceneManager.LoadScene(escena);
    }
}
