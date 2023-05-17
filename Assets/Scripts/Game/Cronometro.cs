using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cronometro : MonoBehaviour
{
    [SerializeField] private GameObject gameObjectTimer; 
    public float timer = 0;
    public TextMeshProUGUI TimerPro;
    void Update()
    {
        timer -= Time.deltaTime;
        
        TimerPro.text= "" + timer.ToString("f0");

        if (timer < 0)
        {
            Destroy(gameObjectTimer);
        }
    }
}
