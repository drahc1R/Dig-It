using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class credits : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void Return()
    {
        SceneManager.LoadScene(sceneName: "credits");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
