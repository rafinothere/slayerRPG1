using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    // Defines a method for interaction that takes a character as input
    void Interact(CharacterData character);
}
