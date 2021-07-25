using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl2coll : MonoBehaviour
{
    bool haveKey = false;
    public GameObject soundBox;
    //  bool collisionActivated = false;

    // Use this for initialization
    void Start()
    {
        haveKey = false;

    }

    // Update is called once per frame
    void Update()
    {
        //  if ((Input.GetKey(KeyCode.F))){
        //      collisionActivated = true;
        //  }
        //  else
        //   {
        //     collisionActivated = false;
        //   }
    }


    void OnCollisionEnter2D(Collision2D collis)
    {

    }

    void OnTriggerStay2D(Collider2D coll)

    {
        if (coll.gameObject.tag == "fox")
        {
            SceneManager.LoadScene(sceneName: "gameOver (level 2)");
        }

        if (coll.gameObject.tag == "key")
        {
            haveKey = true;
        }
        if (coll.gameObject.tag == "exitDoor")
        {
            if (haveKey)
            {

                SceneManager.LoadScene(sceneName: "Level_3");
            }

        }

        //if (collisionActivated)
        //  {
        //     Destroy(coll.gameObject);
        //  }



        if (coll.gameObject.tag == "SparkBlock")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(coll.gameObject);
            }

            //increment spark count
        }
        if (coll.gameObject.tag == "Bomb")
        {
            if (Input.GetKey(KeyCode.Space))

            {
                Destroy(coll.gameObject);
                SceneManager.LoadScene(sceneName: "gameOver");
            }
        }


        else if (coll.gameObject.tag == "emerald")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(soundBox, transform.position, transform.rotation);
                Destroy(coll.gameObject);
            }
        }
        else if (coll.gameObject.tag == "Enemy")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(soundBox, transform.position, transform.rotation);
                Destroy(coll.gameObject);
            }
            else
            {

            }
        }
        else
        {

        }
    }
}
