using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SDA/EnemyData")]
public class EnemyData : ScriptableObject
{
    public float ShootingRate;
    public float BulletSpeed;
    public bool AutoAim;

}
