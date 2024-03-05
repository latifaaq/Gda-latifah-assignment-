using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerA5 : MonoBehaviour
{
    private Counter m_counter;
    [SerializeField] private AudioSource deathSound; // Reference to the AudioSource component for death sound
    [SerializeField] private GameObject hitParticlePrefab; // Reference to the particle system prefab for when enemy is hit

    private void Start()
    {
        m_counter = FindObjectOfType<Counter>();
        //StartCoroutine(MovementCoroutine());
    }
   /* private IEnumerator MovementCoroutine()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        while (true)
        {
            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.up;
                yield return new WaitForFixedUpdate();
            }
            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.zero * 0.1f;
                yield return new WaitForFixedUpdate();
            }
            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.down;
                yield return new WaitForFixedUpdate();
            }
            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.zero * 0.1f;
                yield return new WaitForFixedUpdate();
            }
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "PlayerBull")
        {
            m_counter.IncreaseCounter();
            // Instantiate hit particle system
            Instantiate(hitParticlePrefab, transform.position, Quaternion.identity);
            // Play death sound
            PlayDeathSound();
            Destroy(gameObject);
        }
    }
    void PlayDeathSound()
    {
        if (deathSound != null) // Check if the AudioSource component is assigned
        {
            deathSound.Play(); // Play the death sound
        }
    }
}
