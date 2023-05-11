using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    public GameObject hitEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
            // take damage here
        if(collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}