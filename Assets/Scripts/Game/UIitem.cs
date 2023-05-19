using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIitem : MonoBehaviour
{
    [SerializeField] private Image m_itemImage;
    [SerializeField] private TMP_Text m_itemText;
    public void SetInfo(string p_name, Sprite p_sprite, Color p_itemRenderColor)
    {
        m_itemText.text = p_name;
        m_itemImage.sprite = p_sprite;
        m_itemImage.color = p_itemRenderColor;
    }
}
