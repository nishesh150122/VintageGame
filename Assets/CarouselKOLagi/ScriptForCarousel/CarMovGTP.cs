using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovGTP : MonoBehaviour
{
    public Transform[] positions; // Define the positions in the Inspector
    public float moveSpeed = 5.0f;

    private int currentPositionIndex = 0;
    private bool isMoving = false;
    private void Update()
    {
        if (isMoving)
        {
            MoveToPosition(positions[currentPositionIndex].position);
        }
    }
    private void MoveToPosition(Vector3 targetPosition)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        if (transform.position == targetPosition)
        {
            isMoving = false;
        }
    }
    public void MoveCarousel()
    {
        if (!isMoving)
        {
            currentPositionIndex = (currentPositionIndex + 1) % positions.Length;
            isMoving = true;
        }
    }
}
