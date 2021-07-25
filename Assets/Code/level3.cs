using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class level3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PlayNext3()
    {
SceneManager.LoadScene(sceneName: "Level_3");
        Debug.Log("Load next level");
    }
    
}
