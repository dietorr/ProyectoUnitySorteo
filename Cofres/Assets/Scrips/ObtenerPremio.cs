using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObtenerPremio : MonoBehaviour {

    public Text porcentaje;

	// Use this for initialization
	void Start () {
        porcentaje.text = CofresManager.total + "%" ;
	}

}
