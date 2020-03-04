using UnityEngine;

public class PlayerLookat : MonoBehaviour
{
    private RaycastHit hit;
    public Camera camera;

    // Update is called once per frame
    private void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition); ;
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 999, Color.red);
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 LookPosition = new Vector3(hit.point.x, this.transform.position.y, hit.point.z);
            transform.LookAt(LookPosition);
        }
    }
}