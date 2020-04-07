using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float cooldownTime;
    public float currentTime;

    public bool canShoot = true;
    public float demage;

    public ParticleSystem hitParticle;
    public ParticleSystem entityHitParticle;

    public void timer()
    {
        if (canShoot == false)
        {
            if (currentTime < cooldownTime)
            {
                currentTime += Time.deltaTime;
            }
            else
            {
                canShoot = true;
                currentTime = 0;
            }
        }
    }

    public virtual void triggerDown()
    {
        shoot();
    }

    public virtual void triggerHold()
    {
        shoot();
    }

    public virtual void shoot()
    {
    }
}