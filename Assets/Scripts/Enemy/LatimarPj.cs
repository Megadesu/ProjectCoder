using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatimarPj : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            Debug.Log("Dañado por el enemigo");
        }
        
    }
}
