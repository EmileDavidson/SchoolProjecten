using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameChecker : MonoBehaviour
{
    public float speed = 50;
    public bool hasnumber = false;
    private int random = 0;
    public float posx;
    public float posy;
    public bool clicked = false;
    public int deaths = 0;
    public bool spawned = false;

    private void Start()
    {
        random = 1;
        hasnumber = true;
        StartCoroutine(nextmove());
        spawned = true;
    }

    private void Update()
    {
        move();
    }

    private void OnMouseDown()
    {
        if (clicked == false)
        {
            deaths += 1;
            GameObject.Find("GameMananger").GetComponent<GameManager>().addScore(100);
            clicked = true;
        }
    }

    public void Click()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        posy = transform.position.y;
        if (posy < -100)
        {
            GameObject.Find("GameMananger").GetComponent<GameManager>().clickedRemovedChickens += 1;
            Destroy(gameObject);
        }
    }

    public void move()
    {
        if (clicked == true) { Click(); return; }

        if (hasnumber == false)
        {
            hasnumber = true;
            random = Random.Range(1, 5);
            StartCoroutine(nextmove());
        }
        if (random == 1)
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * 0);
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (random == 2)
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * 45);
            transform.position += Vector3.up * speed * Time.deltaTime;
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (random == 3)
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * 90);
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (random == 4)
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * -45);
            transform.position += Vector3.up * speed * Time.deltaTime;
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (random == 5)
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * -90);
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        posx = transform.position.x;
        posy = transform.position.y;
        if (posx > 110)
        {
            random = 5;
        }
        if (posx < -100)
        {
            random = 3;
        }
        if (posy > 145)
        {
            GameObject.Find("GameMananger").GetComponent<GameManager>().EscapedRemovedChickens += 1;
            Destroy(gameObject);
        }
    }

    private IEnumerator nextmove()
    {
        int r = Random.Range(1, 2);
        yield return new WaitForSeconds(r);
        hasnumber = false;
    }
}