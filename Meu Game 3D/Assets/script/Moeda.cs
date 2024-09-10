using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public int velocidadeGiro = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameMenager>().SubtrairMoedas(Valor:1);
            Destroy(gameObject);
        }
    }


    void Update()
    {
        transform.Rotate(Vector3.forward * velocidadeGiro * Time.deltaTime);
    }
}
