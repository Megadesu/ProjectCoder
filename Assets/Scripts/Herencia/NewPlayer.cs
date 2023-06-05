using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewPlayer :PlayableCharacter, IHealthEntity
{
    public Inventory m_inventory;

    private void Update()
    {
        var l_horizontal = Input.GetAxis("Horizontal");
        var l_vertical = Input.GetAxis("vertical");

        var l_moveDir = new Vector3(l_horizontal, 0, l_vertical).normalized;
        MoveCharacter(l_moveDir);
    }
    //public float GetHealth() {
    //  return m_healthController.GetCurrentHealth();
    
    //}

}

public class Inventory
{

}