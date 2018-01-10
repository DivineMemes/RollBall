using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineNumbers : MonoBehaviour
{
    IEnumerator CoroutineCounting()
    {
        int number = 0;
        while(number < 11)
        {
            number++;
            yield return null;
        }
    }
	
	void Start()
    {
        StartCoroutine(CoroutineCounting());
    }
}
