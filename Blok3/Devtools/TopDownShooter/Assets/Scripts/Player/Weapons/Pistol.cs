using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public GameObject bullet;

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
        GameObject bulletObj = Instantiate(bullet);
        bulletObj.transform.position = (this.transform.position + this.transform.forward);
        bulletObj.GetComponent<Bullets>().SetDirection(transform.forward);
        bulletObj.GetComponent<Bullets>().setup(10, 10f, demage);
    }
}