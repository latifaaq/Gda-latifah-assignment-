using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;//Assignment5
    [SerializeField] private float m_shootingRate; //Assignment5

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0.0f, m_shootingRate); //Assignment5
    }
    private void Shoot() //Assignment5
    {
        Instantiate(m_bullet, transform.position + Vector3.up, Quaternion.identity); //Assignment5
    }
}
