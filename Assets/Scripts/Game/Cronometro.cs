using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public float timer = 0;
    public Text textoTimer;
    public TextMeshProUGUI TimerPro;
    void Update()
    {
        timer -= Time.deltaTime;
        //textoTimer.text = "" + timer.ToString("f0");

        TimerPro.text= "" + timer.ToString("f0");

        if (timer < 0)
        {
            //Eliminar personaje
        }
    }
}
