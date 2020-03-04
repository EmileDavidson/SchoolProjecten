using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveSprite : MonoBehaviour
{
    // Start is called before the first frame update

    private float startPosX;
        private float startPosY;
        private bool isBeingHeld = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Destroy(gameObject);
    }
}
