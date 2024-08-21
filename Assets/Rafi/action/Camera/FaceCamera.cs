using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    public Camera targetCamera;

    void Update()
    {
        if (targetCamera != null)
        {
            // Get the direction to the camera
            Vector3 direction = targetCamera.transform.position - transform.position;
            // Calculate the rotation needed to look at the camera
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            // Only change the y-axis rotation
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, targetRotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        }
    }
}
