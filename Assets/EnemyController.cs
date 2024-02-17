using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)//Assignment5
    {
        if (collision.gameObject.tag == "PlayerBullet")//Assignment5
        {
            Destroy(gameObject);//Assignment5
        }
    }
}
