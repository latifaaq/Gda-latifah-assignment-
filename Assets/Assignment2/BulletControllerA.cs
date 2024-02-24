using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private float m_lifetime;

    void Start()
    {
        Destroy(gameObject, m_lifetime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.forward * m_speed;
    }
}
