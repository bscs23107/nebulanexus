
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1enemy : MonoBehaviour
{
    
    public Vector3 initialForce = new Vector3(5f, 0, 0); // Movement speed and direction

    void Start()
    {
       
    }

    private void FixedUpdate()
    {

        // Check for boundary limits
        transform.Translate(initialForce * Time.fixedDeltaTime);

        if (transform.position.x > 7 || transform.position.x < -7)
        {
            initialForce.x = -initialForce.x; // Reverse direction
        }
    }
}
