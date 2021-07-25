using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSound : MonoBehaviour {
    public AudioSource SoundSource;
    public AudioClip SoundClip;
	// Use this for initialization
	void Start ()
    {
        SoundSource.clip = SoundClip;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SoundSource.Play(); 
        }
		
	}
}
