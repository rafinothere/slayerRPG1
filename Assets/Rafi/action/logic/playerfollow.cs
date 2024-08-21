using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfollow : MonoBehaviour
{
    public Transform playerTransform; // Reference to the player's transform
    private Vector3 cameraOffset;     // The initial offset between the camera and the player

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial offset based on current position differences between player and camera
        cameraOffset = transform.position - playerTransform.position;
    }

    // LateUpdate is called after all Update methods
    void LateUpdate()
    {
        // Update camera position based on player position and initial offset
        // This will make the camera follow the player's position
        transform.position = playerTransform.position + cameraOffset;
    }
}