using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

    
    public float startingTime = 0f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - startingTime > 47f)
        {
            SceneManager.LoadScene(sceneName: "beginning scene");
        }
	}
}
