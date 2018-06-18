using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour {
    private Rigidbody rb;
    private bool moveL;
    private bool moveR;

    // Use this for initialization
    void Start()
    {
        moveL = true;
       // transform.Translate(new Vector3(0, -5, 0) * Time.deltaTime);
        //  rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //  rb.AddForce(-20, 0, 0);
        //  rb.AddForce(0, 0, 20);
    }

    void Update()
    {
       if(moveL)
        transform.Translate(new Vector3(0, -5, 0) * Time.deltaTime);
       else if(moveR)
            transform.Translate(new Vector3(0, 5, 0) * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("tttt");
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == ("Laser_Trigger"))
        {
            moveL = true;
            moveR = false;
          //  transform.Translate(new Vector3(0, -5, 0) * Time.deltaTime);
        }
        else if (collision.tag == ("Laser_Trigger_L"))
        {
            moveL = false;
            moveR = true;
            //  transform.Translate(0,0,0);

         //   transform.Translate(new Vector3(0, 5, 0) * Time.deltaTime);
        }
    }
}
