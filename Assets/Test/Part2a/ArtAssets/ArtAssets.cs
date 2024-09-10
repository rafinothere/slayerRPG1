using UnityEngine;

public class ArtAssets : MonoBehaviour
{
    public Sprite[] characterSprites;
    public Sprite[] environmentSprites;
    public Sprite[] itemSprites;
    public Sprite[] enemySprites;

    // Method to create and assign character sprites
    public void CreateCharacterSprites()
    {
        // Implement logic to load and assign character sprites
        Debug.Log("Character sprites created and assigned.");
    }

    // Method to create and assign environment art
    public void CreateEnvironmentArt()
    {
        // Implement logic to load and assign environment art
        Debug.Log("Environment art created and assigned.");
    }

    // Method to create and assign item sprites
    public void CreateItemSprites()
    {
        // Implement logic to load and assign item sprites
        Debug.Log("Item sprites created and assigned.");
    }

    // Method to create and assign enemy sprites
    public void CreateEnemySprites()
    {
        // Implement logic to load and assign enemy sprites
        Debug.Log("Enemy sprites created and assigned.");
    }

    // Example of how you might retrieve a specific sprite by name
    public Sprite GetCharacterSprite(string characterName)
    {
        foreach (var sprite in characterSprites)
        {
            if (sprite.name == characterName)
            {
                return sprite;
            }
        }
        Debug.LogWarning("Character sprite not found: " + characterName);
        return null;
    }

    // Other methods to retrieve specific sprites can be implemented similarly
}
