using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camer : MonoBehaviour
{
    public GameObject player;
    float speed = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = player.transform.position;
        
        transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Y))
            transform.Rotate(0, -1, 0);
        if (Input.GetKey(KeyCode.U))
            transform.Rotate(0, 1, 0);
    }

}
