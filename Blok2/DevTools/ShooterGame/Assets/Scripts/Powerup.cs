using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject pickupEffect;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HOI");
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }

    private void Pickup()
    {
        Debug.Log("iets");
        GameObject particle = Instantiate(pickupEffect, transform.position, transform.rotation);
        Destroy(particle, 1.1f);

        Debug.Log("Niets");
        //spawn a cool effect

        // apply effect to the player

        // remove power up object
        Destroy(gameObject);
    }
}