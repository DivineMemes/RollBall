using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodPickup : MonoBehaviour
{

    // Use this for initialization
    public int heal;
    public float rotationSpeedX;
    public float rotationSpeedY;
    public float rotationSpeedZ;

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
                playerController.health += heal;
                Destroy(gameObject);
            }
        }
    }
}
