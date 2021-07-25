using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(sceneName: "Level_2");
        Debug.Log("Load next level");
    }
}
