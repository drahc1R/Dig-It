using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpDestroy : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Destroy(gameObject, 0.4f);
      
    }
	
	// Update is called once per frame
	void Update () {
        //transform.position += Vector3.left;
        //transform.position += Vector3.right;
        
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        Debug.Log("Yo");
        /* if (coll.gameObject.tag == "Enemy")
        {
            Debug.Log("Better Yo");
            Destroy(coll.gameObject);

        }

       if (coll.gameObject.tag == "emerald")
        {
            Destroy(coll.gameObject);

        }
        */
       // Destroy(coll.gameObject);
    }
}
 
