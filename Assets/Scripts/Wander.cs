using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    Rigidbody rb;
    public float distance;
    public float radius;
    public float speed;

    public float wanderTime;
    float timer;
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	

    Vector3 doWander()
    {
        Vector3 wanderTarget = (Random.insideUnitSphere * radius) * distance;
        wanderTarget += transform.position;

        Vector3 dir = wanderTarget - transform.position;
        return dir.normalized;
    }

    public Vector3 moveDir;
    void Update()
    {
        if (timer <= 0)
        {
            moveDir = doWander();
            timer = wanderTime;
        }

        rb.AddForce (moveDir * speed);
    }
}
