
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count2 : MonoBehaviour {

    public Text score;

    //private Rigidbody2D rb2d;
    private int count;


    // Start is called before the first frame update
    void Start()
    {
     //   rb2d = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        
        
            if (other.gameObject.CompareTag("emerald"))
            {
             if (Input.GetKey(KeyCode.Space))
                {
                count = count + 1;
                score.text = "Gems:" + count.ToString();
                other.gameObject.SetActive(false);
              }
            }
        
    }
         

       
    
}
