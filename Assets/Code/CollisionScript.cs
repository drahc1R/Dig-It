using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour {
    bool haveKey = false;
    //  bool collisionActivated = false;
    bool isPowers;
    public GameObject soundBox;
    // Use this for initialization
    void Start () {
        haveKey = false;
        isPowers = false;
    }
	
	// Update is called once per frame
	void Update () {
        isPowers = SuperCollesionScript.isPower;
    }


    void OnCollisionEnter2D(Collision2D collis)
    {
        
    }
    
    void OnTriggerStay2D(Collider2D coll)

    {
        if(coll.gameObject.tag == "fox")
        {
            if (!isPowers)
            {
                SceneManager.LoadScene(sceneName: "gameOver");
            }
        }

        if(coll.gameObject.tag == "key")
        {
            haveKey = true;
        }
        if (coll.gameObject.tag == "exitDoor")
        {
            if(haveKey){

                SceneManager.LoadScene(sceneName: "Level_2");
            }
            
        }

        //if (collisionActivated)
      //  {
       //     Destroy(coll.gameObject);
      //  }



        if(coll.gameObject.tag == "SparkBlock")
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
