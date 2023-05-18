using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class LightBehaviour : MonoBehaviour
{
    [SerializeField] private Light[] m_lightsToSpawn;
    [SerializeField] private List<Light> m_lightsList;
    public struct KeyData
    {
        public string color;
        public bool Potion;
    }

    //Tenemos que terminar de desarrollar las puertas
    private Dictionary<string, KeyData> m_keysDictonary = new Dictionary<string, KeyData>();


    [ContextMenu("Ola Viteh")]
    private void GetNameFromLastIndex()
    {
        Debug.Log(m_lightsToSpawn[m_lightsToSpawn.Length - 1].name);
    }



    private void InstantiateAllLights()
    {
        foreach (Light l_light in m_lightsToSpawn)
        {
            //Puedo recorrer el listado, pero en caso de instanciarlo, me dice. Specified cast is not valid. Googlee pero no lo puedo resolver
            Debug.Log(l_light.name);
        }

    }

    private void Awake()
    {

        KeyData m_redKeyData = new KeyData()
        {
            color= "Red",
            Potion = false,
        };
        KeyData m_blueKeyData = new KeyData()
        {
            color = "Blue",
            Potion = true,
        };
        KeyData m_yellowKeyData = new KeyData()
        {
            color = "Yellow",
            Potion = false,
        };

        m_keysDictonary.Add("Red", m_redKeyData);
        m_keysDictonary.Add("Blue", m_redKeyData);
        m_keysDictonary.Add("Yellow", m_redKeyData);
        printRedKeyData();
        printBlueKeyData();
        InstantiateAllLights();
        PrintList(m_lightsList);
        PrintListReversed(m_lightsList);
    }




    private void Start()
    {
    }

    private void printRedKeyData()
    {
        if (m_keysDictonary.TryGetValue("Red", out KeyData l_redKeyData))
        {
            Debug.Log(l_redKeyData.color + l_redKeyData.Potion);

        }

    }

    private void PrintList(List<Light> lightList)
    {

        for (int i = 0; i < lightList.Count; i++)
        {
            Debug.Log(lightList[i].name);
        }

    }

    private void PrintListReversed(List<Light> lightListReversed)
    {
        lightListReversed.Reverse();
        for (int i = 0; i < lightListReversed.Count; i++)
        {
            Debug.Log(lightListReversed[i].name);
        }

    }

    private void printBlueKeyData()
    {
        if (m_keysDictonary.TryGetValue("Blue", out KeyData l_blueKeyData))
        {
            Debug.Log(l_blueKeyData.color + l_blueKeyData.Potion);

        }

    }

    public struct InventoryItem
    {
        public int amount;
        public ItemData itemData;
    }

    public struct ItemData
    {
        public string id;
    }

    public class Inventory
    {
        private Dictionary<string, InventoryItem> m_items;

        public void AddToInventory(ItemData p_itemData, int p_quantity)
        {
            if (m_items.ContainsKey(p_itemData.id))
            {
                var l_inventoryItem = m_items[p_itemData.id];
                l_inventoryItem.amount += p_quantity;
                m_items[p_itemData.id] = l_inventoryItem;
            }
            else
            {
                var l_inventoryItem = new InventoryItem();
                l_inventoryItem.itemData = p_itemData;
                l_inventoryItem.amount = p_quantity;
                m_items.Add(p_itemData.id, l_inventoryItem);
            }
        }

        public void UseItemFromInventory(string p_id, int p_quantity)
        {
            if (m_items.ContainsKey(p_id))
            {
                var l_inventoryItem = m_items[p_id];
                l_inventoryItem.amount -= p_quantity;
                if (l_inventoryItem.amount <= 0)
                {
                    m_items.Remove(p_id);
                    return;
                }

                m_items[p_id] = l_inventoryItem;
            }
            else
            {
                Debug.LogWarning($"{p_id} was not found");
            }
        }
    }



}
