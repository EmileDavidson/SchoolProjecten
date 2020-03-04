using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Animator animator;
    public float rotatespeed = 6f;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1))
        {
            animator.SetBool("Aiming", true);
        }
        else
        {
            animator.SetBool("Aiming", false);
        }

        float rotX = Input.GetAxis("Mouse X") * rotatespeed;
    }
}