using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControllerA5 : MonoBehaviour
{
    //[SerializeField] private float m_speed;
    [SerializeField] private float m_lifetime;
    [SerializeField] private string m_ignoredTag;

    private float m_speed;
    private Rigidbody m_rigidbody;

    void Start()
    {
        Destroy(gameObject, m_lifetime);
        m_rigidbody = GetComponent<Rigidbody>();
    }
    public void Init(float speed)
    {
        m_speed = speed;    
    }
    void FixedUpdate()
    {
        m_rigidbody.velocity = Vector3.forward * m_speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != m_ignoredTag)
        {
            Destroy(gameObject);
        }
    }
}
