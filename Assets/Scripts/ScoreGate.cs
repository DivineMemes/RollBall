using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGate : MonoBehaviour
{
    public int ScoreGoal;

    void Start()
    {
        
    }


    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            var playerController = GetComponent<BallController>();

            if (playerController.score >= ScoreGoal)
            {
                Destroy(gameObject);
            }
        }
    }
}
