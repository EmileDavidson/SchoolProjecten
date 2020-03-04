using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public float speed = 5;

    public float x;
    // Update is called once per frame

    private void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

        x = transform.position.x;
        if (x >= 18)
        {
            Destroy(gameObject);
        }
    }
}