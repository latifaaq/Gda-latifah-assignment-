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
        InitializeComponents();
    }

    private void OnEnable()
    {
        EnablePlayerInput();
    }

    private void OnDisable()
    {
        DisablePlayerInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void InitializeComponents()
    {
        playerAction = new PlayerAction();
        rigidbody = GetComponent<Rigidbody>();

        if (rigidbody == null)
        {
            Debug.LogError("Rigidbody is NULL for player!");
        }
    }

    private void EnablePlayerInput()
    {
        playerAction.Gameplay.Enable();
    }

    private void DisablePlayerInput()
    {
        playerAction.Gameplay.Disable();
    }

    private void MovePlayer()
    {
        movement = playerAction.Gameplay.Move.ReadValue<Vector2>();
        rigidbody.velocity = new Vector3(movement.x, 0, movement.y) * speed;
    }
}