using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }


    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.name.StartsWith("missile"))
        //{
        //    Destroy(gameObject);
        //}
    }
}
