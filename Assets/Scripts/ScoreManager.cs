using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int m_currentScore;

    public void Add(int p_score)
    {
        m_currentScore += p_score;
        Debug.Log(m_currentScore);
    }
}
