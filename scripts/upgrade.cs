using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgrade : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 75f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

    }
}
