using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public float distanceFromCenter = 2.0f;
    public Vector3 rotationAxis = Vector3.up;

    private Vector3 initialPosition;

    private void Start()
    {
        // Store the initial position of the cube
        initialPosition = transform.position;
    }

    private void Update()
    {
        // Calculate the angle based on time and rotation speed
        float angle = Time.time * rotationSpeed;

        // Calculate the new position of the cube using sine and cosine functions
        float x = initialPosition.x + Mathf.Cos(angle) * distanceFromCenter;
        float z = initialPosition.z + Mathf.Sin(angle) * distanceFromCenter;

        // Set the new position of the cube
        transform.position = new Vector3(x, initialPosition.y, z);

        // Rotate the cube around the initial position
        transform.RotateAround(initialPosition, rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
