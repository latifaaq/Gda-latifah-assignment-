using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    /*[SerializeField] private GameObject m_bullet;//Assignment5
    [SerializeField] private float m_shootingRate; //Assignment5
    [SerializeField] private EnemyData m_enemyData;//A7
    //private Coroutine m_corotine;

    void Start()
    {
        //InvokeRepeating("Shoot", 0.0f, m_shootingRate); //Assignment5
        //InvokeRepeating("Shoot", 0.0f, m_enemyData.ShootingDelay);//A7
       // m_corotine = 
            StartCoroutine(ShootingCoroutine());
    }
    private IEnumerator ShootingCoroutine()
    {
        while (true)
        {
            for(int i = 0; i < 3; i++)
            {
                Shoot();
                yield return new WaitForSeconds(0.3f);
            }
            yield return new WaitForSeconds(m_enemyData.ShootingDelay);
        }
        /*int counter = 0;
        while (true)
        {
            Debug.Log("Hello" +  counter.ToString());
            yield return new WaitForSeconds(time);
            ++counter;
        }*/
    //Debug.Log("Begin waiting for 5 seconds");
    //Instantiate(m_bullet, transform.position + Vector3.forward, Quaternion.identity);
    //yield return new WaitForSeconds(time);
    //Debug.Log("Done waiting for 5 seconds");
    /*}
    private void Shoot() //Assignment5
    {
        GameObject newBullet = Instantiate(m_bullet, transform.position + Vector3.up, Quaternion.identity); //Assignment5
        newBullet.GetComponent<BulletController>().Init(m_enemyData.BulletSpeed);
    }*/
    [SerializeField] private GameObject bulletPrefab;//A8
    [SerializeField] private float shootingRate = 1f; // Adjust the rate of fire here

    void Start()
    {
        StartCoroutine(ShootCoroutine());
    }

    private IEnumerator ShootCoroutine()
    {
        while (true)
        {
            for (int i = 0; i < 3; i++) // Shoot three bullets
            {
                Shoot();
                yield return new WaitForSeconds(0.3f); // Wait between each shot
            }
            yield return new WaitForSeconds(shootingRate); // Wait before shooting again
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, transform.position + Vector3.up, Quaternion.identity);
    }
}
