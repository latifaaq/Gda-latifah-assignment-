using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;//Assignment5
    //[SerializeField] private float m_shootingRate; //Assignment5
    [SerializeField] private EnemyData m_enemyData;//A7

    private void Start()
    {
        //InvokeRepeating("Shoot", 0.0f, m_shootingRate); //Assignment5
        InvokeRepeating("Shoot", 0.0f, m_enemyData.ShootingDelay);//A7
    }
    private void Shoot() //Assignment5
    {
        GameObject newBullet = Instantiate(m_bullet, transform.position + Vector3.up, Quaternion.identity); //Assignment5
        newBullet.GetComponent<BulletController>().Init(m_enemyData.BulletSpeed);
    }
}
