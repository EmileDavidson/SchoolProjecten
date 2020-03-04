using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public CharacterController controller;

    private void Update()
    {
        Playermove();
        //Gravity();
    }

    public void Playermove()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    this.transform.position += this.transform.forward * 10 * Time.deltaTime;
        //}

        float xDir = Input.GetAxisRaw("Horizontal");
        float zDir = Input.GetAxisRaw("Vertical");

        //Vector3 move = transform.right * xDir + transform.forward * zDir;
        //controller.Move(move * speed * Time.deltaTime);
        Vector3 move = new Vector3(xDir, 0, zDir) * speed * Time.deltaTime;
        controller.Move(move);
        //transform.position += new Vector3(xDir, 0, zDir) * speed * Time.deltaTime;
    }
}