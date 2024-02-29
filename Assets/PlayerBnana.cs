using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBnana : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private Animator m_animator;
    private Rigidbody m_rigidbody;
    private void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        bool moving = false;

        if(Input.GetKey(KeyCode.UpArrow))
        {
            m_rigidbody.velocity = Vector3.forward * m_speed;
            moving = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_rigidbody.velocity = Vector3.back * m_speed;
            moving = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_rigidbody.velocity = Vector3.right * m_speed;
            moving = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_rigidbody.velocity = Vector3.left * m_speed;
            moving = true;
        }
        if (!moving)
        {
            m_rigidbody.velocity = Vector3.zero;
        }
        m_animator.SetBool("Running", moving);
        transform.rotation = Quaternion.LookRotation(m_rigidbody.velocity);
    }

}
