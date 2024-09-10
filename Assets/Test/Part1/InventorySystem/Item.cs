using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public string Name;
    public ItemType ItemType;
    public bool HasCurse;
    public Sprite itemIcon; // Added this line to support item icons

    public abstract void Use(CharacterData character);

    public virtual void EquipEffect(CharacterData character)
    {
        // Default implementation or override in subclasses
    }
}

public enum ItemType
{
    Weapon,
    Armor,
    Book
    // Add other item types as needed
}
