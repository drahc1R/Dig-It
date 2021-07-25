using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperCollesionScript : MonoBehaviour {
   
    public static float powerUpUse;
    public static bool isPower;
	// Use this for initialization
	void Start () {
        powerUpUse = 0;
        isPower = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}



 void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy" || coll.gameObject.tag == "emerald" || coll.gameObject.tag == "Bomb" || coll.gameObject.tag == "breakableStone")
        {

            if (Input.GetKey(KeyCode.F))
            {
           
      
           
                        if (!(coll.gameObject.tag == "key") || !(coll.gameObject.tag == "fox"))
                        {
                       
                            Destroy(coll.gameObject);
                      
                        powerUpUse += .00014f;
                        isPower = true;
                    Invoke("PowerOff", 1.5f);
                        
                       //isPower = false;    
                }
                        else
                        {
                        
                            return;
                        }
                   
 }
              
            }
        
    }
    void PowerOff()
    {
        isPower = false;
    }
  }

