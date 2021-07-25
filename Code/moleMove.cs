
using UnityEngine;
using System.Collections;

public class moleMove : MonoBehaviour
{
    public Animator anim1;
    public Rigidbody rigidBody;

    public float speed = 1f;
    
    public Sprite lanternLeft1, lanternRight1, digdown, digup;
    public GameObject rightHB;
    public GameObject leftHB;
    public GameObject upHB;
    public GameObject downHB;
    public GameObject superHB;

    static float velocity;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }


    void Update()
    
    {

       



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim1.SetBool("Left", true);
            anim1.SetBool("Down", false);
            anim1.SetBool("Up", false);
            anim1.SetBool("Right", false);
            anim1.SetBool("F", false);

            rightHB.GetComponent<PolygonCollider2D>().enabled = false;
            downHB.GetComponent<PolygonCollider2D>().enabled = false;
            upHB.GetComponent<PolygonCollider2D>().enabled = false;
            superHB.GetComponent<PolygonCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = lanternLeft1;
            transform.position += Vector3.left * speed * Time.deltaTime;
            leftHB.GetComponent<PolygonCollider2D>().enabled = true;



        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            anim1.SetBool("Right", true);
            anim1.SetBool("Down", false);
            anim1.SetBool("Left", false);
            anim1.SetBool("Up", false);
            anim1.SetBool("F", false);

            leftHB.GetComponent<PolygonCollider2D>().enabled = false;
            downHB.GetComponent<PolygonCollider2D>().enabled = false;
            upHB.GetComponent<PolygonCollider2D>().enabled = false;
            superHB.GetComponent<PolygonCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = lanternRight1;
            transform.position += Vector3.right * speed * Time.deltaTime;
            rightHB.GetComponent<PolygonCollider2D>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.F))
        {
            superHB.GetComponent<PolygonCollider2D>().enabled = true;
            leftHB.GetComponent<PolygonCollider2D>().enabled = false;
            downHB.GetComponent<PolygonCollider2D>().enabled = false;
            upHB.GetComponent<PolygonCollider2D>().enabled = false;
            rightHB.GetComponent<PolygonCollider2D>().enabled = false;
            anim1.SetBool("Right", false);
            anim1.SetBool("Down", false);
            anim1.SetBool("Left", false);
            anim1.SetBool("Up", false);
            anim1.SetBool("F", true);


        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            anim1.SetBool("Up", true);
            anim1.SetBool("Down", false);
            anim1.SetBool("Right", false);
            anim1.SetBool("Left", false);
            anim1.SetBool("F", false);

            downHB.GetComponent<PolygonCollider2D>().enabled = false;
            rightHB.GetComponent<PolygonCollider2D>().enabled = false;
            leftHB.GetComponent<PolygonCollider2D>().enabled = false;
            superHB.GetComponent<PolygonCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = digup;
            transform.position += Vector3.up * speed * Time.deltaTime;
            upHB.GetComponent<PolygonCollider2D>().enabled = true;
        }



        else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim1.SetBool("Down", true);
            anim1.SetBool("Up", false);
            anim1.SetBool("Right", false);
            anim1.SetBool("Left", false);
            anim1.SetBool("F", false);

            upHB.GetComponent<PolygonCollider2D>().enabled = false;
            rightHB.GetComponent<PolygonCollider2D>().enabled = false;
            leftHB.GetComponent<PolygonCollider2D>().enabled = false;
            superHB.GetComponent<PolygonCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = digdown;
            transform.position += Vector3.down * speed * Time.deltaTime;
            downHB.GetComponent<PolygonCollider2D>().enabled = true;

        }
        else
        {
            Vector3 v;
            v = GetComponent<Rigidbody2D>().velocity;
            velocity = v.magnitude;
            anim1.SetFloat("Speed", velocity);
            anim1.SetBool("Down", false);
            anim1.SetBool("Up", false);
            anim1.SetBool("Right", false);
            anim1.SetBool("Left", false);
            anim1.SetBool("F", false);

        }
    }
}
    