using UnityEngine.UI;
using System.Collections;

//using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public int demage = 10;
    public float range = 500;
    public float fireRate = 15f;
    public float offSize = 1f;
    public int impactForce = 10;

    //public float inpactForce = 30f;
    public int maxAmmo = 10;

    public int currentAmmo;
    public float reloadTime = 1f;
    public bool isReloading = false;
    public Camera ThirdPerson;
    public float AnimationLoadTime = 2;
    public float nextTimeToFire = 0f;
    public GameObject reloadingTXT;

    // start is called at the start of the game
    private void Start()
    {
        currentAmmo = maxAmmo;
        reloadingTXT.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (isReloading == true)
        {
            return;
        }
        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
        }
        if (Input.GetKey(KeyCode.Mouse0) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 3f / fireRate;
            shoot();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            reloadTime += reloadTime;
            StartCoroutine(Reload());
        }
    }

    private void shoot()
    {
        currentAmmo--;
        RaycastHit hit;

        Vector3 offset = ThirdPerson.transform.position + (ThirdPerson.transform.forward * offSize);
        if (Physics.Raycast(offset, ThirdPerson.transform.forward, out hit, range, 1 << 9 | 1 << 9 | 1 << 11))
        {
            //Checks if the target got the component "Targets" if it has it does the functie TakeDemage with the gunDemage
            Targets targets = hit.transform.GetComponent<Targets>();
            Debug.Log(hit.transform.name);
            if (targets != null)
            {
                targets.TakeDamage(demage);
            }

            //doesnt work (work in progress)

            if (hit.rigidbody != null)
            {
                Debug.Log("heeft force");
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }

    //Reloading functie triggerd when currentAmmo <= 0 with a waitforseconds reloadTime so you need to wait
    private IEnumerator Reload()
    {
        reloadingTXT.SetActive(true);
        //UserInterfaceScript.enabled();
        isReloading = true;
        Debug.Log("reloading..");
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloading = false;
        reloadingTXT.SetActive(false);
        reloadTime = 1f;
    }
}