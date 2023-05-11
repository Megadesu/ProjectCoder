using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemigoZombie : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public float rangoDeAlerta;
    public LayerMask capaDelJugador;
    public Transform jugador;
    public float velocidad;
    
    bool estarAlerta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       estarAlerta = Physics.CheckSphere(transform.position, rangoDeAlerta, capaDelJugador);
        if (estarAlerta == true)
        {
            animator.SetBool("walk", true);
           
            transform.LookAt( new Vector3(jugador.position.x, transform.position.y, jugador.position.z));
            transform.position = Vector3.MoveTowards(transform.position,new Vector3(jugador.position.x, transform.position.y, jugador.position.z),velocidad * Time.deltaTime);
        }
        else
        {
            animator.SetBool("walk", false);
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
    }
}
