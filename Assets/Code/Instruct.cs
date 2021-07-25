using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instruct : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {


    }
    public void Instructions()
    {
        SceneManager.LoadScene(sceneName: "Instructions");

    }
}
