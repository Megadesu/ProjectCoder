using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;


public struct Costumer
{
    public string costumerName;
    public string costumerID;
}
public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private Enemy[] m_enemysToSpawn;
    [SerializeField] private List<Enemy> m_enemyList;
    private List<Costumer> m_myCostumers = new List<Costumer>();
    private Queue<Costumer> m_costumersQueue = new Queue<Costumer>();
    private Stack<Costumer> m_costumersStack = new Stack<Costumer>();


    private void Awake()
    {
        m_enemyList.Add(m_enemysToSpawn[0]);
        m_enemyList.RemoveAt(2);

        var l_obtainedCostumer = TryGetCostumer(out Costumer p_myCostumer);
        if (l_obtainedCostumer)
        {
            Debug.Log(p_myCostumer.costumerName);
        }
    }
    private bool TryGetCostumer(out Costumer p_costumer)
    {
        return m_costumersQueue.TryDequeue(out p_costumer);
    }
























    //private Costumer ObtainCostumer()
    //{
    //    if (m_myCostumers.Count > 0) { 
    //    var l_myCostumer = m_myCostumers[0];
    //        m_myCostumers.RemoveAt(0);
    //        return l_myCostumer;
    //    }
    //    return default;
    //}
    //private Costumer ObtainCheatCostumer()
    //{
    //    if (m_myCostumers.Count > 0)
    //    {
    //        var l_myCostumer = m_myCostumers[m_myCostumers.Count -1];
    //        m_myCostumers.RemoveAt(m_myCostumers.Count - 1);
    //        return l_myCostumer;
    //    }
    //    return default;
    //}


    //    private void Awake()
    //    {
    //        //m_enemyList = new List<Enemy>();
    //        m_enemyList.Add(m_enemysToSpawn[1]);

    //        Var l_obtainedCostumer = TryGetCostumer(out Costumer p_myCostumer);
    //        if (l_obtainedCostumer)
    //        {
    //            Debug.Log(p_myCostumer.costumerName);
    //        }


    //    }
    //    private bool (out Costumer p_costumer ){
    //        return m_costumersStack.TryPop(out p_costumer);
    //        }
    //private bool TryGetCostumer(out Costumer p_costumer)
    //{
    //    return m_costumersQueue.TryQueue(out p_costumer);
    //}
}
