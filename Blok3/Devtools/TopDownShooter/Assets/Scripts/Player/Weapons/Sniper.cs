using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : Weapon
{
    public RaycastHit hit;

    public override void triggerDown()
    {
        shoot();
    }

    public override void triggerHold()
    {
        shoot();
    }

    public override void shoot()
    {
        if (canShoot == false) { return; }
        canShoot = false;
        //wat er moet gebeuren voor het schieten
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.Log(hit.collider.name);
            Debug.Log(hit.collider.tag);
            if (hit.collider.gameObject.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().TakeDemage(10);
                ParticleSystem particleOBJ = Instantiate(entityHitParticle);
                particleOBJ.transform.position = hit.point;
                Destroy(particleOBJ, 2);
            }
        }
    }
}