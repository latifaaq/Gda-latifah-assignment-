using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;
    [SerializeField] private float m_shootingInterval = 1.0f;
    [SerializeField] private float m_moveDistance = 1.0f;
    [SerializeField] private float m_moveSpeed = 1.0f;

    private Vector3 m_startPosition;
    private Vector3 m_endPosition;

    void Start()
    {
        // Store the initial position of the enemy
        m_startPosition = transform.position;

        // Calculate the end position based on the move distance
        m_endPosition = m_startPosition + Vector3.up * m_moveDistance;

        // Start the shooting coroutine
        StartCoroutine(ShootCoroutine());

        // Start the movement coroutine
        StartCoroutine(MoveCoroutine());
    }

    private IEnumerator ShootCoroutine()
    {
        while (true)
        {
            // Shoot 3 times
            for (int i = 0; i < 3; i++)
            {
                Shoot();
                yield return new WaitForSeconds(m_shootingInterval);
            }

            // Wait for the shooting interval
            yield return new WaitForSeconds(m_shootingInterval);
        }
    }

    private IEnumerator MoveCoroutine()
    {
        while (true)
        {
            // Move from start to end position
            yield return MoveToPosition(m_endPosition);

            // Wait for a short duration
            yield return new WaitForSeconds(0.5f);

            // Move from end to start position
            yield return MoveToPosition(m_startPosition);

            // Wait for a short duration
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void Shoot()
    {
        Instantiate(m_bullet, transform.position + Vector3.forward, Quaternion.identity);
    }

    private IEnumerator MoveToPosition(Vector3 targetPosition)
    {
        float distance = Vector3.Distance(transform.position, targetPosition);
        float duration = distance / m_moveSpeed;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;
    }
}
