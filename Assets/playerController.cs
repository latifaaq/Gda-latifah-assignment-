using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            ShootBullet();
        }
    }
    void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.transform.parent = transform;
    }
}
