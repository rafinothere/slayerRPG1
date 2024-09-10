using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton instance of GameManager
    public static GameManager Instance { get; private set; }

    // Reference to the currently active character
    public CharacterData currentCharacter;

    private void Awake()
    {
        // Ensure that only one instance of GameManager exists (Singleton pattern)
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keeps the GameManager alive between scenes
        }
        else
        {
            Destroy(gameObject); // Destroys duplicate GameManagers
        }
    }
}
