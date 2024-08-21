using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mapCamera; // Assign the "map cam" in the Inspector
    public Camera battleCamera;

    private void Start()
    {
        // Set the "map cam" as the active camera
        mapCamera.enabled = true;

        // Disable the main camera
        battleCamera.enabled = false;
    }
}