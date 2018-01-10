using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCoroutine : MonoBehaviour
{
    public float Timer;
    public Vector3 Scale;


    IEnumerator CoroutineScale()
    {
        while(transform.localScale != Scale)
        {

            transform.localScale += Vector3.one;
            //Vector3.lerp
            yield return new WaitForSeconds(Timer);
        }

        
    }
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(CoroutineScale());
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
