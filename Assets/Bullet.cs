using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 direction;
    private Transform target;
    private bool isFollowingTarget;

    public float speed = 10f;

    public void SetDirection(Vector3 dir)
    {
        direction = dir;
        isFollowingTarget = false;
    }

    public void SetTarget(Transform _target)
    {
        target = _target;
        isFollowingTarget = true;
    }

    void Update()
    {
        if (isFollowingTarget)
        {
            if (target != null)
            {
                direction = (target.position - transform.position).normalized;
            }
            else
            {
                isFollowingTarget = false;
            }
        }

        transform.position += direction * speed * Time.deltaTime;
    }
}
