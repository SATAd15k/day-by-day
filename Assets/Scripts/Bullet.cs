// aka bullect / projectile

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 10f; // speed of bullet
    public int Damage = 25; // damage of bullet

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Speed * Time.deltaTime;
    }
}
