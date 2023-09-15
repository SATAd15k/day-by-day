using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Health _health;

    // Start is called before the first frame update
    void Start()
    {
        _health = GetComponent<Health>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyManager enemy = collision.transform.GetComponent<EnemyManager>(); // gets enemy manager script and stores it within enemy

        if (enemy != null)
        {
            _health.Dmg(20);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) // keep this here for spikes so that the player can walk through them rather than walk on top of them
    {
        _health.Dmg(200); // will instantly kill the player if they touch this..... value 200 used to be 20; intially used for spikes
    }
}
