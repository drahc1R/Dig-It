﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void Return()
    {
        SceneManager.LoadScene(sceneName: "tips");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
