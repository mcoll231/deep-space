using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{
    public ParticleSystem explosionParticle;

    [SerializeField] float health, maxHeath = 3f;

    private void Start()
    {
        health = maxHeath;
    }
    public void TakeDamage(float damageAmount)
    {
        health-= damageAmount; // 3 -> 2 ->1-> 0 = dead!

        if (health <= 0)
            {
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            KillCount.singleton.incrementkills();
        }
    }
}