using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class PlayerBanana : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Animator animator;

    private Rigidbody rigidbody;

    private void Start()
    {
        InitializeComponents();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void InitializeComponents()
    {
        rigidbody = GetComponent<Rigidbody>();
        if (rigidbody == null)
        {
            Debug.LogError("Rigidbody is NULL for player!");
        }
    }

    private void MovePlayer()
    {
        bool moving = false;
        Vector3 movementDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementDirection = Vector3.forward;
            moving = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movementDirection = Vector3.back;
            moving = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementDirection = Vector3.right;
            moving = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementDirection = Vector3.left;
            moving = true;
        }

        rigidbody.velocity = movementDirection.normalized * speed;
        animator.SetBool("Running", moving);
        if (moving)
        {
            transform.rotation = Quaternion.LookRotation(movementDirection);
        }
    }
}
