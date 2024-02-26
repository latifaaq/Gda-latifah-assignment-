using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootA5 : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;
    [SerializeField] private float m_shootingRate;
    [SerializeField] private EnemyData m_data;

    [System.Obsolete]
    void Start()
    {
        //InvokeRepeating("Shoot", 0.0f, m_data.ShootingRate);
        StartCoroutine(ShootingCoroutine());
    }

    [System.Obsolete]
    private IEnumerator ShootingCoroutine()
    {
        while (true)
        {
            for(int i = 0; i < 3; i++)
            {
                Shoot();
                yield return new WaitForSeconds(0.3f);
            }
            yield return new WaitForSeconds(m_data.ShootingRate);
        }
    }

    [System.Obsolete]
    private void Shoot()
    {
        GameObject newBullet = Instantiate(m_bullet, transform.position + Vector3.forward, Quaternion.identity);
        newBullet.GetComponent<BulletControllerA5>().Init(m_data.BulletSpeed, true, m_data.AutoAim);
    }
}
