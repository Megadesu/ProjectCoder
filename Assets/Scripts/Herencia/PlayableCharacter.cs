using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController
{
    private float m_maxHealth;
private float currentHealth; 
    public HealthController(float p_maxHealth)
    {
    m_maxHealth = p_maxHealth;
    }

    public void TakeDamage(float p_damage)
    {
        currentHealth -= p_damage;
    }

    public void GetHeal(float p_heal)
    {
        currentHealth += p_heal;
    }
    public float GetCurrentHealth() => currentHealth;
}
public class PlayableCharacter : Entity

{
    [SerializeField] private Animator m_animator;
    [SerializeField] private float m_maxHealth;
    [SerializeField] private float m_speed;
    private HealthController m_healthController;

    private void Awake()
    {
        m_healthController = new HealthController(m_maxHealth);
    }
    protected void MoveCharacter(Vector3 p_direction)
    {
        transform.position += p_direction * m_speed * Time.deltaTime;
    }


}

