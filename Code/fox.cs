using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fox : MonoBehaviour {

    public float speed;
    private Transform target;
    float val;
    public GameObject hog;
    public Transform rotatingFox;

    // Use this for initialization
    void Start() {

        target = GameObject.FindGameObjectWithTag("main").GetComponent<Transform>();
        val = SuperCollesionScript.powerUpUse;



    }



    // Update is called once per frame
    void Update() {

        Vector3 dir = hog.transform.position - transform.position;

        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(rotatingFox.rotation, lookRotation, Time.deltaTime).eulerAngles;
        rotatingFox.rotation = Quaternion.Euler(0f, 0f, rotation.z);


        val = SuperCollesionScript.powerUpUse;
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime + val);
    }

    void OnTriggerStay2D(Collider2D coll)
    { 
    if(coll.gameObject.tag == "main")
    { 
       SceneManager.LoadScene(sceneName: "gameOver");
    }
    }
}
