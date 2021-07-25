using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour {
   

    public GameObject lockedDoor;
    public GameObject goodDoor;
	void Start () {

        

    }
	
	
	void Update () {
		
	}
    void OnTriggerStay2D(Collider2D coll)

    {
        
        if (coll.gameObject.tag == "key")
        {

            
            Destroy(lockedDoor);
            Destroy(coll.gameObject);
        }
       
    }
}
