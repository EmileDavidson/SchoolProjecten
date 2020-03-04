using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //This number will decide how fast the player will be moving.
    public float currentSpeed;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {

        //check for input. If there's W input, it means the player is moving.
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            currentSpeed = 1;
            this.transform.Translate(new Vector3(0, 0, currentSpeed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftControl))
            {
            currentSpeed = 1.5f;
            this.transform.Translate(new Vector3(0, 0, currentSpeed) * Time.deltaTime);
       }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            currentSpeed = 0.5f;
           this.transform.Translate(new Vector3(0, 0, -currentSpeed) * Time.deltaTime);
      }
        //Move the player according to input.
        
        animator.SetFloat("Speed", currentSpeed);
        currentSpeed = 0;



    }
}
