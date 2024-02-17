using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShootingController : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;//Assignment2&3
    [SerializeField] private float m_shootingRate; //Assignment3

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//Assignment2 with GetKey Assignment3 with GetKeyDown
        {
            //Instantiate(m_bullet, transform.position, Quaternion.identity); //Assignment2
            InvokeRepeating("Shoot", 0.0f, m_shootingRate); //Assignment3
        }
        if(Input.GetKeyUp(KeyCode.Space))//Assignment3
        {
            CancelInvoke(); //Assignment3
        }
    }
    private void Shoot() //Assignment3
    {
        Instantiate(m_bullet, transform.position, Quaternion.identity); //Assignment3
    }
}
