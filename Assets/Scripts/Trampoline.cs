using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float yForce;
    public float speed;
	void Start ()
    {
        
	}
	
	
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision other)
    {

        if (other.collider.tag == "Player")
        {
            var playerController = other.gameObject.GetComponent<BallController>();
            {
                if(playerController!= null)
                {
                    Vector3 force = new Vector3(0, yForce, 0);
                    playerController.rb.AddForce(force * speed * Time.deltaTime, ForceMode.Impulse);
                }
            }
        }

    }
}
