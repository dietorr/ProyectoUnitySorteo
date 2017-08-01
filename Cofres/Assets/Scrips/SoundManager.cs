using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioSource SonidoAbrirCofre;


    // Use this for initialization
    void Awake()
    {
    }



    // Update is called once per frame
    void Update()
    {
        if (!(GetComponent<AudioSource>().isPlaying))
        {
            GetComponent<AudioSource>().Play();
        }
        else
        {
            //Debug.log("Something is wrong with Music.");
        }
    }
}
