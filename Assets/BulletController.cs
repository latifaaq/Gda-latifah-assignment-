using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //[SerializeField] private float m_speed;//Assignment2&5
    [SerializeField] private float m_lifetime;//Assignment2&5
    [SerializeField] private string m_ignoredTag;//Assignment5

    private float m_speed;
    private Rigidbody m_rigidbody;//Assignment5

    void Start()
    {
        Destroy(gameObject, m_lifetime);//Assignment2&5
        m_rigidbody = GetComponent<Rigidbody>();//Assignment5
    }

    public void Init(float speed)
    {
        m_speed = speed;
    }
    void FixedUpdate() //Assignment2&5 with Fixed Assignment3 without Fixed
    {
        m_rigidbody.velocity = Vector3.forward * m_speed;//Assignment5
        // transform.position += Vector3.forward * m_speed *Time.deltaTime;//Assignment2 without deltatime Assignment3 with deltatime
    }
    private void OnCollisionEnter(Collision collision)//Assignment5
    {
        if (collision.gameObject.tag != m_ignoredTag)//Assignment5
        {
            Destroy(gameObject);//Assignment5
        }
    }
}
