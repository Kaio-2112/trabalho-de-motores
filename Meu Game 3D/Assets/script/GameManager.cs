using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{

    public TextMeshProUGUI hud, msgVitoria;
    public int restantes;
    
    
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;
        
    }

public void SubtrairMoedas(int valor)
{
    restantes = restantes - valor;
    {hud.text = $"Moedas restante: {restantes}";
    
    if (restantes <= 0)
msgVitoria.text = "Parabéns!";
    }
}


    // Update is called once per frame
    void Update()
    {
        
    }
}
