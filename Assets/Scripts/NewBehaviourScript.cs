using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LC : MonoBehaviour
{

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
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
        
        transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime );
    }
}
