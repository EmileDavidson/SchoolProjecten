using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public Weapon[] weapons = new Weapon[3];
    public Weapon currentWeapon;

    private void Start()
    {
        currentWeapon = weapons[0];
    }

    private void Update()
    {
        currentWeapon.timer();
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 999, Color.yellow);

        if (Input.GetKey(KeyCode.Mouse0))
        {
            currentWeapon.triggerHold();
            //Debug.Log(currentWeapon);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            currentWeapon.triggerDown();
            //Debug.Log(currentWeapon);
        }

        //weapon switcher
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                if (currentWeapon == weapons[i])
                {
                    int check = i - 1;
                    if (check < 0)
                    {
                        return;
                    }
                    currentWeapon = weapons[i - 1];
                    return;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                if (currentWeapon == weapons[i])
                {
                    int check = i + 1;
                    if (check >= weapons.Length)
                    {
                        return;
                    }
                    currentWeapon = weapons[i + 1];
                    return;
                }
            }
        }
    }

    public void setWeapon(Weapon weapon)
    {
        currentWeapon = weapon;
        Debug.Log(currentWeapon);
    }
}