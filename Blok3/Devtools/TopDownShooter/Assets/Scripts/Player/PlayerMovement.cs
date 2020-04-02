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
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            float xDir = Input.GetAxisRaw("Horizontal");
            float zDir = Input.GetAxisRaw("Vertical");
            Vector3 move = new Vector3(xDir, 0, zDir) * speed * Time.deltaTime;
            controller.Move(move);
        }
    }
}