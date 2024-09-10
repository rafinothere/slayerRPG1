using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    // Method to display the main menu
    public void DisplayMainMenu()
    {
        // This method could enable the main menu UI elements
        Debug.Log("Displaying Main Menu");
        // Additional logic for displaying main menu can be added here
    }

    // Method to start a new game
    public void StartNewGame()
    {
        Debug.Log("Starting New Game");
        // Load the game scene, assuming "GameScene" is the name of the main gameplay scene
        SceneManager.LoadScene("GameScene");
    }

    // Method to load a saved game
    public void LoadGame()
    {
        Debug.Log("Loading Game");
        // Load the saved game data and transition to the gameplay scene
        // Implement your load game logic here
        SceneManager.LoadScene("GameScene"); // Assuming the same scene for now
    }

    // Method to exit the game
    public void ExitGame()
    {
        Debug.Log("Exiting Game");
        // Exit the application
        Application.Quit();
    }
}
