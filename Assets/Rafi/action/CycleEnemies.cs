using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleEnemies : MonoBehaviour
{
    public float rotationSpeed = 60f; // Speed of rotation in degrees per second

    void Update()
    {
        // Calculate the rotation for this frame
        float rotationStep = rotationSpeed * Time.deltaTime;

        // Apply the rotation
        transform.Rotate(0, rotationStep, 0);
    }
}