using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkNoise : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    bool walking = false;

    // Use this for initialization
    void Start()
    {
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            InvokeRepeating("PlayMusic", 0f, 1f);
            walking = false;
            
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PlayMusic();
            walking = false;
           

        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PlayMusic();
            walking = false;
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PlayMusic();

            walking = false;
           
        }
        else
        {
            MusicSource.Stop();
            walking = true;
        }
    }
    void PlayMusic()
    {
        if (walking == true)
        {
            MusicSource.Play();
        }
    }
}
