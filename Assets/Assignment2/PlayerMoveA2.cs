using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveA2 : MonoBehaviour
{
    [SerializeField] private float m_speed;

    void FixedUpdate()
    {
       if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * m_speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * m_speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * m_speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * m_speed;
        }
    }
}
