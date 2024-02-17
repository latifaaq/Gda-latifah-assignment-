using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float m_speed;//Assignment2,3&5
    private Rigidbody m_rigidbody;//Assignment5

    // Start is called before the first frame update
    void Start() //Assingnment5
    {
        m_rigidbody = GetComponent<Rigidbody>();//Assignment5
    }

    // Update is called once per frame
    void FixedUpdate()//Assignment2&5 with Fixed Assignment3 without Fixed
    {

        bool moving = false;//Assignment5

        if (Input.GetKey(KeyCode.UpArrow))//Assignment2,3&5
        {
            //transform.position += Vector3.forward * m_speed * Time.deltaTime; //Assignment2 without deltatime Assignment3 with deltatime
            m_rigidbody.velocity = Vector3.forward * m_speed;//Assignment5
            moving = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))//Assignment2,3&5
        {
            //transform.position += -Vector3.forward * m_speed * Time.deltaTime; //Assignment2 without deltatime Assignment3 with deltatime
            m_rigidbody.velocity = -Vector3.forward * m_speed;//Assignment5
            moving = true;

        }
        if (Input.GetKey(KeyCode.LeftArrow))//Assignment2,3&5
        {
            //transform.position += Vector3.left * m_speed * Time.deltaTime; //Assignment2 without deltatime Assignment3 with deltatime
            m_rigidbody.velocity = Vector3.left * m_speed;//Assignment5
            moving = true;

        }
        if (Input.GetKey(KeyCode.RightArrow))//Assignment2,3&5
        {
            //transform.position += Vector3.right * m_speed * Time.deltaTime; //Assignment2 without deltatime Assignment3 with deltatime
            m_rigidbody.velocity = Vector3.right * m_speed;//Assignment5
            moving = true;

        }
        if (!moving)//Assignment5
        {
            m_rigidbody.velocity = Vector3.zero;//Assignment5
        }
    }
}
