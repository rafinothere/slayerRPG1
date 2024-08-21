using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Make sure to include this namespace

public class start : MonoBehaviour
{
    // This method is called when the user clicks on the sprite
    void OnMouseDown()
    {
        // Change the scene to the one labeled 'action'
        SceneManager.LoadScene("action");
    }
}