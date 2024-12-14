using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -100)
        {
            transform.position = new Vector3(Random.Range(7, -7), 1, Random.Range(22, 25));
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, 0, -0.4f);
    }
}
