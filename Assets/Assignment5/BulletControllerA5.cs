using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControllerA5 : MonoBehaviour
{
    //[SerializeField] private float m_speed;
    [SerializeField] private float m_lifetime;
    [SerializeField] private string m_ignoredTag;
    [SerializeField] private AudioSource collisionSound;
    [SerializeField] private float m_explosionRadius = 20.0f;
    [SerializeField] private float m_explosionForce = 1000.0f;


    private float m_speed;
    private Rigidbody m_rigidbody;
    private PlayerMoveA5 m_player;
    private Quaternion m_quat;
    private bool m_followPlayer;
    private bool m_explosive;
    void Start()
    {
        Destroy(gameObject, m_lifetime);
        m_rigidbody = GetComponent<Rigidbody>();
    }

    public void Init(float speed, bool lookAtPlayer, bool followPlayer, bool explosive)
    {
        m_speed = speed; 
        m_explosive = explosive;
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
            PlayCollisionSound();
            if(m_explosive)
            {
                Collider[] colliders = Physics.OverlapSphere(transform.position, m_explosionRadius);
                foreach(var collider in colliders)
                {
                    Rigidbody rb;
                    if(collider.TryGetComponent<Rigidbody>(out rb))
                    {
                        rb.AddExplosionForce(m_explosionForce, transform.position, m_explosionRadius, 1.0f);
                    }
                }
            }
        }
    }
    void PlayCollisionSound()
    {
        if (collisionSound != null) // Check if the AudioSource component is assigned
        {
            collisionSound.Play(); // Play the collision sound
        }
    }
}
