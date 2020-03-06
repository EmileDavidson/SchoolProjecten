﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public RaycastHit hit;
    public Camera camera;

    private void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 999, Color.red);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.GetComponent<PlayerHealth>())
                {
                    hit.transform.GetComponent<PlayerHealth>().OnHit(10);
                }
            }
        }
    }
}