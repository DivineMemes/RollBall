using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadPickup : MonoBehaviour
{

    public int scoreSubtracted;
    public float rotationSpeedX;
    public float rotationSpeedY;
    public float rotationSpeedZ;
    // Use this for initialization
    void Start()
    {
        rotationSpeedX = Random.Range(-10, 10);
        rotationSpeedY = Random.Range(-10, 10);
        rotationSpeedZ = Random.Range(-10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeedX * 3, rotationSpeedY * 3, rotationSpeedZ * 3);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var playerController = other.GetComponent<BallController>();
            if (playerController != null)
            {
                playerController.score -= scoreSubtracted;
                rotationSpeedX = Random.Range(-10, 10);
                rotationSpeedY = Random.Range(-10, 10);
                rotationSpeedZ = Random.Range(-10, 10);
                Destroy(gameObject);

            }
        }
    }
}
