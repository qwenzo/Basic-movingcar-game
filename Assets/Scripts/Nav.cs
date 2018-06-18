using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nav : MonoBehaviour {

    private Rigidbody rb;
    private bool inground;
    private int points;
    private float speed;
    public Text Score;
    public Text GameOver;
	// Use this for initialization
	void Start () {
        speed = 1.0f;
        rb = GetComponent<Rigidbody>();
        GameOver.gameObject.SetActive(false);
       GameOver.text="";
        points = 0;
       // inground = true;
       
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
      //  rb.AddForce(new Vector3(0, 20, 0));
        if (Input.GetButton("Jump") && inground == true)
        {
            inground = false;
         //   rb.AddForce (new Vector3(0, 20, 0));
            rb.velocity =(new Vector3(0, 5, 0));
        }
        // float  moveH = Input.GetAxis("Horizontal");
        /*
        if (Input.GetAxis("Horizontal")>0) {
            float moveH = Input.GetAxis("Horizontal");
            rb.AddForce(moveH, 0, 0);
        }
        */

       // transform.Translate(-20, 0, 0);



    }

    private void Update()
    {
        if (Input.GetButton("Jump") && inground == true)
        {
            inground = false;
            //   rb.AddForce (new Vector3(0, 20, 0));
            transform.Translate(new Vector3(0, 10, 0) * Time.deltaTime);
        }

        transform.Translate(new Vector3(-20, 0, 0) *Time.deltaTime*speed);
        float moveH = Input.GetAxis("Horizontal");
        //  transform.Translate(new Vector3(0, 0, moveH) * Time.deltaTime*5);
        rb.AddForce(0, 0, moveH*30);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("floor"))
        inground = true;

        if (collision.gameObject.CompareTag("Deadly"))
        {
            Destroy(this);
            //rb.freezeRotation(true);
           GameOver.text = "Game Over";
            GameOver.gameObject.SetActive(true);

        }
    }

    void GameOverfunction()
    {
        //rb.freezeRotation(true);
        GameOver.text = "Game Over";
       GameOver.gameObject.SetActive(true);
    }

    void  updateScore()
    {
        Score.text = points.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Coin"))
        {
            Debug.Log("lol");
          
            points = points + 10;
            speed=speed+0.1f;
            Destroy(other.gameObject);
            updateScore();


        }

         if(other.tag == ("laser"))
        {
            if (points >= 50)
            {
                points = points - 50;
                speed=speed-5;
            }
            else
            {
                GameOverfunction();
            }
            updateScore();
        }

    }
}
