using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip backgroundmusic;
    public AudioClip place;
    public AudioSource audio;

    // Start is called before the first frame update
    private void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = backgroundmusic;
        audio.volume = 0.1f;
        audio.Play();
    }
}