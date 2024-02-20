using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    /*private KillCounter m_killCounter;//A6&8
     void Start()
     {
         StartCoroutine(MovementCoroutine());
         m_killCounter = FindObjectOfType<KillCounter>();//A6
     }
     private IEnumerator MovementCoroutine()
     {
         Rigidbody rb = GetComponent<Rigidbody>();
         while (true)//A8
         {
             for (int i = 0; i < 200; i++) 
             {
                 rb.velocity = Vector3.up * 0.1f;
                 yield return new WaitForFixedUpdate();
             }
             for (int i = 0; i < 200; i++)
             {
                 rb.velocity = Vector3.zero;
                 yield return new WaitForFixedUpdate();
             }
             for (int i = 0; i < 200; i++)
             {
                 rb.velocity = Vector3.down * 0.1f;
                 yield return new WaitForFixedUpdate();
             }
             for (int i = 0; i < 200; i++)
             {
                 rb.velocity = Vector3.zero;
                 yield return new WaitForFixedUpdate();
             }
         }
     }

     private void OnCollisionEnter(Collision collision)//Assignment5&6
     {
         if (collision.gameObject.tag == "PlayerBullet")//Assignment5&6
         {
             m_killCounter.IncreaseCounter();//A8, and 6 without Instance
             Destroy(gameObject);//Assignment5,6&8
         }
     }*/
    private KillCounter m_killCounter; // Reference to the KillCounter script

    void Start()
    {
        StartCoroutine(MovementCoroutine());
        m_killCounter = FindObjectOfType<KillCounter>(); // Find and store the KillCounter script
    }

    private IEnumerator MovementCoroutine()
    {
        while (true)
        {
            // Moving up
            for (int i = 0; i < 200; i++)
            {
                transform.Translate(Vector3.up * 0.05f);
                yield return null;
            }
            // Moving down
            for (int i = 0; i < 200; i++)
            {
                transform.Translate(Vector3.down * 0.05f);
                yield return null;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            m_killCounter.IncreaseCounter(); // Increase the kill counter
            Destroy(gameObject); // Destroy this enemy
        }
    }
}
