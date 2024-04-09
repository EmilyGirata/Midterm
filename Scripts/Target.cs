using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //Target object is assigned to its set health.
    public float health = 50f;

    //Once the target object takes damage from the gun, it will lose its health resulting for it to
    //be destroyed.
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
