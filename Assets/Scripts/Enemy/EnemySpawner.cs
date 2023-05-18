using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    [SerializeField] private Enemy[] m_enemyToSpawn;
    [SerializeField] private List<Enemy> m_enemyList;

    //[ContextMenu("print name from last index")]

    //private void Awake()
    //{
    //    m_enemyList.Add(m_enemysToSpawn[0]);
    //    m_enemyList.RemoveAt(2);

    //    var l_obtainedCostumer = TryGetCostumer(out Costumer p_myCostumer);
    //    if (l_obtainedCostumer)
    //    {
    //       // Debug.Log(p_myCostumer.costumerName);
    //    }
    //}
    //private bool TryGetCostumer(out Costumer p_costumer)
    //{
        
    //}
};
