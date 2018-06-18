using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingObjects : MonoBehaviour {
    public GameObject wreckingball;
    public GameObject obst;
    public GameObject coin;
    private bool isCoroutineExecuting;
    float tempTime;
    // Use this for initialization
    void Start () {
        createObst();
        createCoin();

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        //  StartCoroutine(ExecuteAfterTime(Random.Range(10, 20)));
        tempTime += Time.deltaTime;
        if (tempTime > 5)
        {
            tempTime = 0;
            createballs();
            }

        }

    void createballs()
    {
        //z = -0.29 , -4.55 ,5.45f
        float[] positions = new float[3];
        positions[0] = -0.29f;
        positions[1] = -4.55f;
        positions[2] = 5.19f;
        wreckingball.transform.position = new Vector3(-115f, 2.13f, positions[Random.Range(0, 3)]);
        Instantiate(wreckingball);
       
    }

void createObst()
    {
        float[] positions = new float[3];
        positions[0] = -0.29f;
        positions[1] = -4.55f;
        positions[2] = 5.19f;
      int   maxNumber = Random.Range(10, 30);
        for (int i = 0; i < 5; i++)
        {
            obst.transform.position = new Vector3(Random.Range(90, -115f), 2.13f, positions[Random.Range(0, 3)]);
            Instantiate(obst);
        }
        

    }

void createCoin()
{
    float[] positions = new float[3];
    positions[0] = -0.29f;
    positions[1] = -4.55f;
    positions[2] = 5.19f;
    int maxNumber = Random.Range(10, 30);
    for (int i = 0; i < maxNumber; i++)
    {
        coin.transform.position = new Vector3(Random.Range(90, -115f), 1.13f, positions[Random.Range(0, 3)]);
        Instantiate(coin);
    }
}

    }



