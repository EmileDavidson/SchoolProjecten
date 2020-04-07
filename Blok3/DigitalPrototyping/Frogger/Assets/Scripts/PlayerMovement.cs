using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera camera;
    public bool SetPareting = false;
    public float jumpkracht = 1.5f;

    private void Update()
    {
        if (camera.transform.position.z == this.transform.position.z)
        {
            SetPareting = true;
            camera.transform.parent = this.transform;
            camera.transform.position = new Vector3(0, 10, this.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += new Vector3(0, 0, jumpkracht);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (!(this.transform.position.x == -8))
            {
                this.transform.position += new Vector3(-jumpkracht, 0, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (this.transform.position.z == -0.5f)
            {
                camera.transform.parent = null;
                SetPareting = false;
            }
            if (!(this.transform.position.z == -4.5f))
            {
                this.transform.position += new Vector3(0, 0, -jumpkracht);
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (!(this.transform.position.x == 8))
            {
                this.transform.position += new Vector3(jumpkracht, 0, 0);
            }
        }
    }
}