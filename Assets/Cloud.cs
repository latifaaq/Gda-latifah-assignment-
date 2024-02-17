using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
       
       float speed = 1f;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
 
}
