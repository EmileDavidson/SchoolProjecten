using UnityEngine;

public class Targets : MonoBehaviour
{
    public float health = 50;

    public void TakeDamage(int demageAmount)
    {
        health -= demageAmount;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}