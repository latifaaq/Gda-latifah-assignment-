using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootA2 : MonoBehaviour
{
    [SerializeField] private float m_bulletSpeed;
    public GameObject m_bullet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        GameObject newBullet = Instantiate(m_bullet, transform.position, Quaternion.identity);
         newBullet.GetComponent<BulletControllerA5>().Init(m_bulletSpeed);
        /*GameObject newBullet = Instantiate(m_bullet, transform.position, Quaternion.identity);
        Rigidbody bulletRigidbody = newBullet.AddComponent<Rigidbody>(); // ????? Rigidbody ????? ???????
        bulletRigidbody.velocity = Vector3.forward * m_bulletSpeed; // ????? ???? ?????? ???????
        newBullet.GetComponent<BulletControllerA5>().Init(m_bulletSpeed);*/
    }
    /*[SerializeField] private GameObject m_bullet;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(m_bullet);
        }
    }*/
}
