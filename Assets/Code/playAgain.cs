using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playAgain : MonoBehaviour { 

    // Use this for initialization
    void Start() { }



        // Update is called once per frame
        public void PlayAgain()
        {
            SceneManager.LoadScene(sceneName: "Level_1");
            Debug.Log("Load next level");
        }
 }