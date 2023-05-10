using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemigo : MonoBehaviour
{
    float speed = 0.5f;

    public Transform target;


    private void Start()
    {
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
    }
    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="WayPoint")
        {
            target = other.gameObject.GetComponent<EnemigoWP>().nextPoint;
            transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        }
    }
}
