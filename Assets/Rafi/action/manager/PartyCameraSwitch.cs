using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraSwitch : MonoBehaviour
{
    public List<Camera> Cameras; // List of your cameras (AllySlotCam1, AllySlotCam2, AllySlotCam3)
    public RenderTexture AllyDisplayTexture; // Reference to your RenderTexture

    private void Start()
    {
        EnableCamera(0); // Enable the first camera initially
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EnableCamera(0); // Switch to camera 1
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EnableCamera(1); // Switch to camera 2
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EnableCamera(2); // Switch to camera 3
        }
        // Add more 'else if' conditions for additional cameras if needed
    }

    private void EnableCamera(int n)
    {
        foreach (var cam in Cameras)
        {
            cam.targetTexture = null; // Disable all cameras
        }
        Cameras[n].targetTexture = AllyDisplayTexture; // Enable the selected camera
    }
}