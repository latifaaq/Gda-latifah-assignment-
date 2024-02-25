using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /*public GameObject bulletPrefab;
    public Transform player;
    public int enemyType;

    private void Start()
    {
        // Find the player GameObject by name
        player = GameObject.Find("player1").transform;

        if (player == null)
        {
            Debug.LogError("Player not found!");
        }
    }

    public void Shoot()
    {
        if (player == null)
        {
            Debug.LogError("Player not found!");
            return;
        }

        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Bullet bulletScript = bullet.GetComponent<Bullet>();

        if (enemyType == 0)
        {
            Vector3 directionToPlayer = (player.position - transform.position).normalized;
            bulletScript.SetDirection(directionToPlayer);
        }
        else if (enemyType == 1)
        {
            bulletScript.SetTarget(player);
        }
    }*/
}
