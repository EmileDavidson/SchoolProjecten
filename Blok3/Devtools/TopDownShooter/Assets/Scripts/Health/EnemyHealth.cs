using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : Health
{
    public Image HealthBar;

    // Start is called before the first frame update
    private void Start()
    {
        starthealth = 50;
        health = starthealth;
    }

    private void Update()
    {
        updatebars(HealthBar);
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}