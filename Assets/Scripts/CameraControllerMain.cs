using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerMain : MonoBehaviour {

    private GameObject car2;
    private Vector3 offset;
    // Use this for initialization
    void Start () {
        car2 = GameObject.Find("Car 2");
        Vector3 offset = car2.transform.position - transform.position;

    }
	
	// Update is called once per frame
	void Update () {
       // transform.position = GameObject.Find("Car 2").transform.position + offset;



    }
}
