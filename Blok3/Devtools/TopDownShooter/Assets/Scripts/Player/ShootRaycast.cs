using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRaycast : MonoBehaviour
{
    public RaycastHit hit;
    public ParticleSystem enemyhit;

    // Update is called once per frame
    private void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 999, Color.yellow);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Vector3 LookPosition = new Vector3(hit.point.x, this.transform.position.y, hit.point.z);
            transform.LookAt(LookPosition);
            Debug.Log(hit.collider.name);
            Debug.Log(hit.collider.tag);
            if (hit.collider.gameObject.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().TakeDemage(10);
                ParticleSystem particleObj = Instantiate(enemyhit);
                particleObj.transform.position = hit.transform.position;
                Destroy(particleObj, 2);
            }
        }
    }
}