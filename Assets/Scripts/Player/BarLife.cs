using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarLife : MonoBehaviour
{


    public Image barraDeVida;

    public float vidaActual;

    public float vidaMaxima;
    void Update()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
    }
}
