using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class TeamPlayer : MonoBehaviour
{
    [SerializeField] private bool isDead;

    private int currentHealth;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyPlayer"))
        {
            var enemy = other.attachedRigidbody.GetComponent<EnemyPlayer>();
            enemy.GetHitByEnemy(this);
        }
    }

    public bool GetHit(int damage = 1)
    {
        isDead = false;
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            isDead = true;
        }


        return isDead;
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
