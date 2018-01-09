using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallController : MonoBehaviour
{


    Rigidbody rb;
    public float speed;
    public int score;
    public int health;

	void Start ()
    {
        score = 0;
        health = 10;
        rb = GetComponent<Rigidbody>();
	}
	

	void Update ()
    {
        //speed = speed * speed;
        Debug.Log(speed);
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontal, 0, vertical);
        rb.AddForce(move * speed * Time.deltaTime);
    }

}
