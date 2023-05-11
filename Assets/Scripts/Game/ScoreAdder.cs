using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdder : MonoBehaviour
{
    [SerializeField] private int m_scoreToAdd;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.J ))
        {
            GameManager.Instance.AddScore(m_scoreToAdd);
        }
    }
}
