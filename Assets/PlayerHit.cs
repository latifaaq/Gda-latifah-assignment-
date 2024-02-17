using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)//Assignment5
    {
        if (collision.gameObject.tag == "EnemyBullet")//Assignment5
        {
            Debug.Log("Player was hit by the enemy bullet!");//Assignment5
        }
    }
}
