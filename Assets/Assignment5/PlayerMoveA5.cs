using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveA5 : MonoBehaviour
{
    [SerializeField] private float m_speed;
    private Rigidbody m_rigidbody;
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_rigidbody.velocity = Vector3.forward * m_speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_rigidbody.velocity = Vector3.back * m_speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_rigidbody.velocity = Vector3.right * m_speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_rigidbody.velocity = Vector3.left * m_speed;
        }
    }
}
