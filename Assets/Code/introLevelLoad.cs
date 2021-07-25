using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {

    }
	
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(sceneName: "Level_1");
        Debug.Log("Load next level");

    }
}
