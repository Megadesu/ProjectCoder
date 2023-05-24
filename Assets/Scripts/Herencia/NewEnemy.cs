using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemy : PlayableCharacter
{

    [SerializeField]private Transform m_target;
    public void PersuitPlayer()
    {
        var l_dir = (m_target.position - transform.position).normalized;

        MoveCharacter(l_dir);
    }

    private void Update()
    {
        if (m_target == null) {
            return;
                }
        PersuitPlayer();
    }
    public void GetTarget(Transform p_target)
    {
        m_target = p_target;
    }
}
