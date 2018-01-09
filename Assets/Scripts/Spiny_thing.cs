using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiny_thing : MonoBehaviour
{
    public float rotationSpeedY;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, rotationSpeedY, 0);
	}
}
