using UnityEngine;

public class Shoot : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject bullet;
    public int activeGun = 0;

    // Update is called once per frame
    private void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 999, Color.yellow);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("gun1");
            activeGun = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("gun2");
            activeGun = 1;
        }
    }

    public void Fire()
    {
        switch (activeGun)
        {
            case 0:
                GameObject bulletObj = Instantiate(bullet);
                bulletObj.transform.position = (this.transform.position + this.transform.forward);
                bulletObj.GetComponent<Bullets>().SetDirection(transform.forward);
                bulletObj.GetComponent<Bullets>().setup(10, 10f, 5);
                break;

            case 1:
                GameObject bulletObj1 = Instantiate(bullet);
                bulletObj1.transform.position = (this.transform.position + this.transform.forward);
                bulletObj1.GetComponent<Bullets>().SetDirection(transform.forward);
                bulletObj1.GetComponent<Bullets>().setup(3, 20f, 20);
                break;
        }
    }
}