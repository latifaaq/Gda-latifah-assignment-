using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;
    private PlayerAction playerAction;
    private Rigidbody rigidbody;
    private Vector2 movement;


    private void Awake()
    {
        playerAction = new PlayerAction();
        rigidbody = GetComponent<Rigidbody>();

        if ( rigidbody == null )
        {
            Debug.LogError("RigidBody is NULL for player!");
        }
        //playerAction.Gameplay.Zoomcamera.perform += Context => Zoom(Context.ReadValue<float>());
    }
    private void OnEnable()
    {
        playerAction.Gameplay.Enable(); 
    }
    private void OnDisable()
    {
        playerAction.Gameplay.Disable();
    }
    private void FixedUpdate()
    {

        movement = playerAction.Gameplay.Move.ReadValue<Vector2>();
        rigidbody.velocity = new Vector3(movement.x, 0, movement.y) * speed;
    }
    /*private void Zoom(float zoomInput)
    {
        Debug.Log(zoomInput);
    }*/
}
