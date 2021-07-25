using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tips : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void GoBack()
    {
        SceneManager.LoadScene(sceneName: "beginning scene");
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
