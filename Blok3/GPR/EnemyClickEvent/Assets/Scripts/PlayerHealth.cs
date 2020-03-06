using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    private void Start()
    {
        startHealth = 100;
        HP = startHealth;
    }

    public void OnHit(int hitDeamgeValue)
    {
        TakeDemage(hitDeamgeValue);
        if (HP <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        this.transform.localScale = this.transform.localScale / 2;
    }
}