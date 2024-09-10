using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    public Text inventoryText; // UI Text for displaying item names
    public GameObject itemIconPrefab; // Prefab for displaying item icons
    public Transform itemIconParent; // Parent transform where item icons will be instantiated

    // Method to show the inventory
    public void ShowInventory(List<Item> items)
    {
        // Clear previous item icons
        foreach (Transform child in itemIconParent)
        {
            Destroy(child.gameObject);
        }

        // Update inventory text
        inventoryText.text = "Inventory:\n";
        foreach (var item in items)
        {
            inventoryText.text += item.Name + "\n"; // Using item.Name

            // Instantiate item icon and set its sprite
            if (itemIconPrefab != null)
            {
                GameObject itemIconObject = Instantiate(itemIconPrefab, itemIconParent);
                Image itemIconImage = itemIconObject.GetComponent<Image>();

                if (itemIconImage != null && item.itemIcon != null)
                {
                    itemIconImage.sprite = item.itemIcon;
                }
                else
                {
                    Debug.LogWarning("Item icon is missing or Image component is not found.");
                }
            }
            else
            {
                Debug.LogWarning("Item icon prefab is not assigned.");
            }
        }
    }
}
