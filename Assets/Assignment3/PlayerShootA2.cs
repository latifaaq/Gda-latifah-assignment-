using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerShootA2 : MonoBehaviour
{
    [SerializeField] private Animator m_animator;
    [SerializeField] private float m_bulletSpeed;
    public GameObject m_bullet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_animator.SetTrigger("Shoot");
            ShootBullet();
        }
    }

     public void ShootBullet()
    {

        GameObject newBullet = Instantiate(m_bullet, transform.position, Quaternion.identity);
        newBullet.GetComponent<BulletControllerA5>().Init(m_bulletSpeed, false, false, true);
     }
}
