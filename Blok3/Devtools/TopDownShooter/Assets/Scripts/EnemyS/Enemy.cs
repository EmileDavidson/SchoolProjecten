using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private bool InPlayerRange = false;
    private float distance;
    private bool canshoot = false;
    public GameObject bullet;

    private void Start()
    {
        StartCoroutine(ShootTimer());
    }

    private void Update()
    {
        if (canshoot == true)
        {
            canshoot = false;
            shoot();
            StartCoroutine(ShootTimer());
        }
        NavMeshAgent agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(this.transform.position);
        distance = (this.transform.position - GameObject.Find("Player").transform.position).magnitude;
        if (distance >= 0.5f) { InPlayerRange = false; }
        if (InPlayerRange == true) { return; }
        Vector3 playerLoc = GameObject.Find("Player").transform.position;

        agent.SetDestination(playerLoc);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            InPlayerRange = true;
        }
    }

    public void shoot()
    {
        GameObject bulletObj = Instantiate(bullet);
        bulletObj.transform.position = (this.transform.position + this.transform.forward * 3);
        bulletObj.GetComponent<Bullets>().SetDirection(transform.forward);
        bulletObj.GetComponent<Bullets>().BounchCount += 5;
    }

    public IEnumerator ShootTimer()
    {
        yield return new WaitForSeconds(5);
        canshoot = true;
    }
}