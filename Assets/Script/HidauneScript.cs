using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidauneScript : MonoBehaviour
{
    public float eskospeed = .4f;
    public float minX = -8.6f; // Minimum X position
    public float maxX = 8.6f;  // Maximum X position
    public SphereMovement smkoobj;

    void Update()
    {
        // Calculate movement input
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate new position based on input and speed
        Vector3 newPosition = transform.position + new Vector3(horizontalInput, 0f, 0f) * eskospeed * Time.deltaTime;

        // Clamp the position within the specified bounds
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        // Apply the new position to the GameObject
        transform.position = newPosition;
        print("speed ko value " + smkoobj.speed);
        if(smkoobj.speed==0f)
        {
            eskospeed = 0f;
            minX = 0f;
            maxX = 0f;
        }
    }
}
