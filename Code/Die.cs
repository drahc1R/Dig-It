using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Kill", 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Kill()
    {
        Destroy(gameObject);
    }
}
