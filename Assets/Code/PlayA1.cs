using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayA1 : MonoBehaviour
{

    // Use this for initialization
    void Start() { }



    // Update is called once per frame
    public void PlayAgain()
    {
        SceneManager.LoadScene(sceneName: "Level_4");
        Debug.Log("Load next level");
    }
}