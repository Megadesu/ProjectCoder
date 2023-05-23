using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    bool IsInteractable { get; }
    void Interact();
}
public class NPC : Entity, IInteractable
{
    [SerializeField] private string[] m_dialogue;
    private void Awake()
    {
        GetName();
    }

    public bool IsInteractable { get;}
    public void Interact()
    {

    }
}
