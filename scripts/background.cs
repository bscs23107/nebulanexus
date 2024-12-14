using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject astroid;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 v = new Vector3(Random.Range(7, -7), 1, Random.Range(22, 25));
            GameObject.Instantiate(astroid, v, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
