using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCamera : MonoBehaviour
{
    /*void FireRay()
     {
         Ray ray = new Ray(transform.position, transform.forward);
         RaycastHit hitData;
         Physics.Raycast(ray, out hitData);
     }*/
    public Transform player; // The player object
    public float horizontalSpeed = 2.0f; // Speed of horizontal rotation
    public float verticalSpeed = 2.0f; // Speed of vertical rotation
    public float distanceFromPlayer = 5.0f; // Initial distance from player
    public float minDistance = 2.0f; // Minimum distance from player
    public float maxDistance = 10.0f; // Maximum distance from player
    public float zoomSpeed = 2.0f; // Speed of zooming

    private float rotationX = 0.0f; // Rotation around x-axis
    private float rotationY = 0.0f; // Rotation around y-axis

    /*void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock cursor to center of screen
    }*/

    void LateUpdate()
    {
        // Update camera rotation based on mouse movement
        rotationX += Input.GetAxis("Mouse X") * horizontalSpeed;
        rotationY -= Input.GetAxis("Mouse Y") * verticalSpeed;

        // Limit vertical rotation to avoid flipping
        rotationY = Mathf.Clamp(rotationY, -90, 90);

        // Calculate camera rotation
        Quaternion rotation = Quaternion.Euler(rotationY, rotationX, 0);

        // Adjust camera distance from player based on mouse scroll wheel
        distanceFromPlayer -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        distanceFromPlayer = Mathf.Clamp(distanceFromPlayer, minDistance, maxDistance);

        // Calculate camera position
        Vector3 negDistance = new Vector3(0.0f, 0.0f, -distanceFromPlayer);
        Vector3 position = rotation * negDistance + player.position;

        // Perform raycast from camera to player and visualize it
        RaycastHit hit;
        if (Physics.Raycast(transform.position, player.position - transform.position, out hit))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red); // Visualize raycast
        }

        // Apply rotation to camera
        transform.rotation = rotation;

        // Allow vertical camera movement with Q and E keys
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += Vector3.up * verticalSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.position -= Vector3.up * verticalSpeed * Time.deltaTime;
        }

        // Apply position to camera after vertical movement
        transform.position = position;
    }
}

        /*Transform player;
        float initialCameraOffset;
        Vector3 cameraRotation;
        //public float distanceFromPlayer;
        //private float rotationX = 0.0f;
        //private float rotationY = 0.0f;
        void Start()
        {
            player = GameObject.FindGameObjectsWithTag("Player1").transform;
            initialCameraOffset = Vector3.Distance(transform.position, player.position);
            cameraRotation = transform.rotation.eulerAngles;
            //Vector3 position = player.position - transform.forward * distanceFromPlayer;
            //rotationY = transform.rotation.eulerAngles.y;
        }
         void Update()
        {
            float mouseX = Input.GetAxis("Mouse X");
            if(mouseX != 0)
            {
                cameraRotation.y += mouseX;
            }
            transform.eulerAngles = cameraRotation;
            Vector3 cameraLookDirection = Quaternion.Euler(cameraRotation) *Vector3.forward;
            transform.position = -cameraLookDirection * initialCameraOffset + player.position;
            transform.position = playerTransform.position + initialCameraOffset;
            Vector3 directionToPlayer = (playerTransform.position - transform.position).normalized;
            float mouseY = Input.GetAxis("Mouse Y");
            transform.rotation = Quaternion.LookRotation(directionToPlayer);

        }*/
