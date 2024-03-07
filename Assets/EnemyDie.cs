using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    public AudioClip deathSoundClip;
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to the enemy
        audioSource = GetComponent<AudioSource>();
        // Assign the death sound clip to the AudioSource
        audioSource.clip = deathSoundClip;
    }

    // Method to be called when the enemy dies
    public void Die()
    {
        // Play the death sound
        if (deathSoundClip != null && audioSource != null)
        {
            audioSource.Play();
        }

        // Destroy the enemy GameObject or deactivate it
        Destroy(gameObject);
    }
}
