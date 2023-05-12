using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    [SerializeField] private Enemy[] m_enemyToSpawn;
    [SerializeField] private List<Enemy> m_enemyList;

    [ContextMenu("print name from last index")]

    private void Awake()
    {
        //m_enemyList = new List<Enemy>();
        m_enemyToSpawn = new Enemy[5];
       
    }
    private void GetNameFromLastIndex()
    {
        
    }
}
