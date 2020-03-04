using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Duck : MonoBehaviour
{
    public int speed = 4;
    private SpriteRenderer sr;
    public Animator animator;
    public AudioClip audioduck;
    public AudioClip audioshot;
    public AudioSource source;
    public Text points;
    public Canvas rendercanvas;

    public bool clicked = false;

    public Camera camera;
    public float x;
    public float y;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (clicked == false)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.down * speed * 2 * Time.deltaTime;
            StartCoroutine(speedmodifier());
        }

        x = transform.position.x;
        y = transform.position.y;

        if (x <= -18) { Destroy(gameObject); }
        if (y <= -6) { Destroy(gameObject); }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            source.PlayOneShot(audioshot);
        }
    }

    public IEnumerator OnMouseDown()
    {
        if (clicked == false)
        {
            source.PlayOneShot(audioduck);
            animator.SetBool("falling", true);
            yield return new WaitForSeconds(0.2f);
            Text textobj = Instantiate(points);
            RectTransform rt = textobj.GetComponent<RectTransform>();
            Vector3 vec = camera.WorldToScreenPoint(new Vector3(this.transform.position.x, this.transform.position.y, 0));
            rt.localPosition = new Vector2(vec.x - 600, vec.y - 300);
            Debug.Log(vec.x + "   " + vec.y);
            textobj.transform.SetParent(rendercanvas.transform, false);

            clicked = true;
        }
    }

    public IEnumerator speedmodifier()
    {
        yield return new WaitForSeconds(1);
        speed += 1;
    }
}