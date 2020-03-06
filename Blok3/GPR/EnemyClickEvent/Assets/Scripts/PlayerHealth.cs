using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : Health
{
    public TextMeshProUGUI text;

    private void Start()
    {
        startHealth = 100;
        HP = startHealth;
        text.text = ("hp: " + HP);
    }

    public void OnHit(int hitDeamgeValue)
    {
        if (HP <= 0) { return; }
        TakeDemage(hitDeamgeValue);
        if (HP <= 0)
        {
            HP = 0;
            Die();
        }
        text.text = ("hp: " + HP);
    }

    public void Die()
    {
        this.transform.localScale = this.transform.localScale / 2;
    }
}