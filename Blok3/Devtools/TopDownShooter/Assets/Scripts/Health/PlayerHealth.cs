using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    public Image healthbar;

    // Start is called before the first frame update
    private void Start()
    {
        starthealth = 1000;
        health = starthealth;
    }

    // Update is called once per frame
    private void Update()
    {
        updatebars(healthbar);
        if (health < 0)
        {
            health = 0;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GetComponent<PlayerHealth>().TakeDemage(10 * Time.deltaTime);
        }
    }
}