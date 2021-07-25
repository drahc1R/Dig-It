using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkAudio : MonoBehaviour {
    public AudioClip MusicClip;
    public AudioSource MusicSource;

    // Use this for initialization
    void Start ()
    {
        MusicSource.clip = MusicClip;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MusicSource.Play();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MusicSource.Play();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MusicSource.Play();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            MusicSource.Play();
        }




    }
}
