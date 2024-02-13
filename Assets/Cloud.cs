using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    /*public GameObject spherePrefab;
    public float shootInterval = 1f;
    private bool shooting = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
       /* if(Input.GetKeyUp(KeyCode.Space) && !shooting)
        {
            InvokeRepeating("ShootSphere", 0f, shootInterval);
            shooting = true;
            {
                else if(Input.GetKeyUp(KeyCode.Space))
                {
                    CancelInvoke("ShootSphere");
                    shooting = false;
                }
            }
        }*/
        float speed = 2f;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
   /* void ShootSphere()
    {
        Instantiate(spherePrefab, Quaternion.identity);
    }*/
}
