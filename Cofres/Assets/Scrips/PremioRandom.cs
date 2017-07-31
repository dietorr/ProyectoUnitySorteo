using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremioRandom : MonoBehaviour {

    public float[] desc = { 5f, 10f, 15f, 20f};
    public float[] prob = { 0.4f, 0.3f, 0.2f, 0.1f};
    private float total = 0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(obtenerDescuento());
        }
    }

    public float obtenerDescuento()
    {
        total = 0f;
        foreach (float num in prob)
        {
            total += num;
        }
        float randNum = Random.Range(0, total);
        //Debug.Log("Numero random: " + randNum);
        for (int i = 0; i < prob.Length; i++)
        {
            if (randNum <= prob[i])
            {
                return desc[i];
            }
            else
            {
                randNum -= prob[i];
            }
        }
        return desc[prob.Length - 1];
    }
}
