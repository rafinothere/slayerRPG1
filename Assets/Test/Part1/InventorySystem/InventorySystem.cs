using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    private List<Item> Items;

    private void Start()
    {
        Items = new List<Item>();
        // Initialize inventory system as needed
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
        Debug.Log($"{item.Name} added to inventory.");
    }

    public void RemoveItem(Item item)
    {
        if (Items.Contains(item))
        {
            Items.Remove(item);
            Debug.Log($"{item.Name} removed from inventory.");
        }
    }

    public void EquipItem(CharacterData character, Item item)
    {
        if (item is Weapon weapon)
        {
            character.EquipWeapon(weapon);
        }
        else if (item is Armor armor)
        {
            character.EquipArmor(armor);
        }
        else
        {
            Debug.LogWarning("Item type not supported for equipping.");
        }
    }

    public void UseItem(Item item, CharacterData character)
    {
        item.Use(character);
    }
}
