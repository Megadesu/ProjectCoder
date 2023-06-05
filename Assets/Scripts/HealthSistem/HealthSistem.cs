using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSistem : MonoBehaviour
{

    [SerializeField] private float m_maxHealth;
    [SerializeField] private float m_invincibilityTime;
    private float m_currentHealth;
    public bool m_isInvincible;

    public float GetCurrentHealth() => m_currentHealth;

    public void Init()
    {
        m_currentHealth = m_maxHealth;
    }
    public void  TakeDamage(float p_damage)
    {
        if (m_isInvincible)
            return;
        m_currentHealth -= p_damage;

        if (m_currentHealth < 0)
        {
            Die();
            m_currentHealth = 0;
        }
    }
    public void GetHeal(float p_healAmount)
    {
        m_currentHealth += p_healAmount;

        if (m_currentHealth > m_maxHealth)
        {
            m_currentHealth = m_maxHealth;
        }
    }
    private void Die()
    {
        m_isInvincible = true;
    }
}
