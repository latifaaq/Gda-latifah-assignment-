using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TriggerEnterScript : MonoBehaviour
{

    // This function is called when another Collider enters the trigger
    /*public GameObject enemyPrefab; // Prefab of the enemy
    public Transform player; // Reference to the player GameObject
    public int numberOfEnemies = 5; // Number of enemies to spawn
    public float spawnInterval = 1f; // Interval between enemy spawns

    private bool hasPlayerEntered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1") && !hasPlayerEntered)
        {
            hasPlayerEntered = true;
            StartCoroutine(SpawnEnemies());
        }
    }

    IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 spawnPosition = player.position + player.forward * 5f; // Spawn in front of the player
            GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            // Animate enemy falling from the sky
            enemy.transform.position = new Vector3(spawnPosition.x, 20f, spawnPosition.z);
            enemy.transform.DOMoveY(0f, 1.5f);

            yield return new WaitForSeconds(spawnInterval);
        }
    }*/
    [SerializeField] private List<EnemyControllerA5> m_enemies;
    private bool m_activated = false;

    private void Awake()
    {
        foreach (EnemyControllerA5 enemy in m_enemies )
        {
            enemy.GetComponent<EnemyShootA5>().ShootOnStart = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!m_activated && other.gameObject.tag == "Player1")
        {
            m_activated = true;
            var seq = DOTween.Sequence();
            foreach (EnemyControllerA5 enemy in m_enemies)
            {
                enemy.gameObject.SetActive(true);

                var pos = enemy.transform.position;

                /*RaycastHit info;
                if(Physics.Raycast(pos, Vector3.down, out info))
                {
                    pos.y = info.point.y + 1;
                }*/
                pos.y = (float)0.3;

                seq.Append(enemy.transform.DOMove(pos, 3)
                    .OnComplete(() =>
                    {
                        enemy.GetComponent<EnemyShootA5>().StarShooting();
                    }));
            }
        }
    }
}
