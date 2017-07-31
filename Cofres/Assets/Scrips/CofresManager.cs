using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CofresManager : MonoBehaviour {

    public int posicion;
    public Animator Estante;
    //Vector3 bar = transform.position;
    public Text texto;
    public GameObject Random;
    public static float total=0;

    public Text ganarTexto;
    public GameObject botonSiguiente;

    private float seleccion = 0.0f;
    private static int cantCofres = 0;

    void OnMouseDown()
    {
        //  texto.transform.position = bar;
        cantCofres = cantCofres + 1;
        texto.gameObject.SetActive(true);
        seleccion = Random.GetComponent<PremioRandom>().obtenerDescuento();
        total = total + seleccion;
        texto.text = seleccion.ToString(); ;
        //Debug.Log(cantCofres);
        if (posicion == 1)
        {
            Estante.SetTrigger("Abrir1");
        }
        else if (posicion == 2){
            Estante.SetTrigger("Abrir2");
        }
        else if(posicion == 3){
            Estante.SetTrigger("Abrir3");
        }
        else
        {
            Debug.Log("error");
        }
    }

    IEnumerator MyCoroutine()
    {
        ganarTexto.text = "Felicitaciones!!! \n Ha ganado un descuento del \n" + total + " %";
        yield return new WaitForSeconds(1);    //Wait one frame
        ganarTexto.gameObject.SetActive(true);
        botonSiguiente.gameObject.SetActive(true);
        cantCofres = 0;
    }

    private void Update()
    {
        if(cantCofres == 3)
        {
            StartCoroutine(MyCoroutine());

        }
    }



}
