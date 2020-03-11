using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour
{
    private Rigidbody rigidbody;
    private float fireSpeed = 15f;
    private Vector3 direction;
    private Vector3 oldVelocity;
    public int BounchCount = 0;
    public int maxBounchCount = 10;
    public float demage = 10;

    private void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        //set direction to player rotation
        rigidbody.velocity = direction * fireSpeed;
    }

    private void Update()
    {
        if (BounchCount >= maxBounchCount)
        {
            Destroy(this.gameObject);
        }
    }

    //on instantiate fixes the direction the bullet will go
    public void SetDirection(Vector3 aDir)
    {
        direction = aDir;
    }

    public void setup(int maxb, float firespeedvalue, float d)
    {
        maxBounchCount = maxb;
        fireSpeed = firespeedvalue;
        demage = d;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            Destroy(this.gameObject);
            other.GetComponent<EnemyHealth>().TakeDemage(demage);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        BounchCount++;
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
            collision.transform.GetComponent<PlayerHealth>().TakeDemage(demage);
        }
    }
}