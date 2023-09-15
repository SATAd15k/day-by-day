// Enemy Movement based off capela: https://github.com/CapelaGames/First2DProjectafteroon2023.2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
[RequireComponent(typeof(Health))]

public class EnemyManager : MonoBehaviour
{
    private Health _health;

    public int Damage = 20;
    // Start is called before the first frame update
    void Start()
    {
        _health = GetComponent<Health>();
    }

    private void OnTriggerEnter2D(Collider2D collision) // when the bullet collides with enemy
    {
        Bullet bullet = collision.GetComponent<Bullet>();
        if (bullet != null)
        {
            _health.Dmg(bullet.Damage); // deal the damage specified by bullet (should be 25)
            Destroy(bullet.gameObject); // destroy the bullet so it is just not infinite
        }
    }
}
