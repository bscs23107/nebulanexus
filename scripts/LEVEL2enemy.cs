using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEVEL2enemy : MonoBehaviour
{
    public Vector3 initialForce = new Vector3(15f, 0, 0); // Movement speed and direction
    //public float rotationSpeed = 75f;


    void Start()
    {

    }

    private void FixedUpdate()
    {
        //transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        // Check for boundary limits
        transform.Translate(initialForce * Time.fixedDeltaTime);

        if (transform.position.x > 7 || transform.position.x < -7)
        {
            initialForce.x = -initialForce.x; // Reverse direction
        }
    }
}
