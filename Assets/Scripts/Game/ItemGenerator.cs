using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public struct ItemData
    {

        public string itemName;
        public Sprite itemSprite;
    public Color itemColor;
    }

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] private UIitem m_itemPrefab;
    [SerializeField] private List<ItemData> m_itemDatas;
    [SerializeField] private RectTransform m_parent;

    private void Awake()
    {
        foreach (var l_itemData in m_itemDatas)
        {
            var l_item = Instantiate(m_itemPrefab, m_parent);
            l_item.SetInfo(l_itemData.itemName, l_itemData.itemSprite, l_itemData.itemColor);
        }
    }
}
