using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{ 
   private KillCounter m_killCounter;//A6&8
    void Start()
    {
        //m_killCounter = FindObjectOfType<KillCounter>();//A6
    }

    private void OnCollisionEnter(Collision collision)//Assignment5&6
    {
        if (collision.gameObject.tag == "PlayerBullet")//Assignment5&6
        {
            KillCounter.Instance.IncreaseCounter();//A8, and 6 without Instance
            Destroy(gameObject);//Assignment5,6&8
        }
    }
}
