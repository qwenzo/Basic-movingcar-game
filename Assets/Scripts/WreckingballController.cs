﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckingballController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(10, 0, 0) * Time.deltaTime);
    }
}
