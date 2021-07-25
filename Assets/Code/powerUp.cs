using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{

    public GameObject myPrefab;
    float T;

    // Use this for initialization
    void Start()
    {
        T = -1.5f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time - T > 1.5f)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Instantiate(myPrefab, transform.position, transform.rotation);
                T = Time.time;
            }
        }
    }

}


