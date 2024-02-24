using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerA5 : MonoBehaviour
{
    private Counter m_counter;

    [System.Obsolete]
    private void Start()
    {
        m_counter = FindObjectOfType<Counter>();
        StartCoroutine(MovementCoroutine());
    }
    private IEnumerator MovementCoroutine()
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
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "PlayerBull")
        {
            m_counter.IncreaseCounter();
            Destroy(gameObject);
        }
    }
}
