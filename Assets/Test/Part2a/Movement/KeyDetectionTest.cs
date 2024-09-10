using UnityEngine;

public class KeyDetectionTest : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W key is being pressed");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S key is being pressed");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A key is being pressed");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D key is being pressed");
        }
    }
}
