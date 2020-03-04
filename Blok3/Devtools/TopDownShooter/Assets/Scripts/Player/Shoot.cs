using UnityEngine;

public class Shoot : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject bullet;

    // Update is called once per frame
    private void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 999, Color.yellow);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    public void Fire()
    {
        GameObject bulletObj = Instantiate(bullet);
        bulletObj.transform.position = (this.transform.position + this.transform.forward);
        bulletObj.GetComponent<Bullets>().SetDirection(transform.forward);
    }
}