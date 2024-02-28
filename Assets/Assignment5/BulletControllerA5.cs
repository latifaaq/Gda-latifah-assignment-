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
    private PlayerMoveA5 m_player;
    private Quaternion m_quat;
    private bool m_followPlayer;
    void Start()
    {
        Destroy(gameObject, m_lifetime);
        m_rigidbody = GetComponent<Rigidbody>();
    }

    public void Init(float speed, bool lookAtPlayer, bool followPlayer)
    {
        m_speed = speed; 
        if(lookAtPlayer)
        {
            m_player = FindObjectOfType<PlayerMoveA5>();
            m_quat = Quaternion.LookRotation(m_player.transform.position - transform.position);
            m_followPlayer = followPlayer;
        }
    }
    void FixedUpdate()
    {
        if(m_followPlayer)
        {
            m_quat = Quaternion.LookRotation(m_player.transform.position - transform.position);
        }
        m_rigidbody.velocity = m_quat * Vector3.forward * m_speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != m_ignoredTag)
        {
            Destroy(gameObject);
        }
    }
}
