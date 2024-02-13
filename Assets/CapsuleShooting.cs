using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleShooting : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;

   // Start is called before the first frame update
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(m_bullet, transform.position, Quaternion.identity);
        }
    }
}
