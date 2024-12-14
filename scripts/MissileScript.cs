 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileScript : MonoBehaviour
{
    public GameObject explosion;
    private shipscript gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<shipscript>();
    }



    private void Update()
    {
        if (transform.position.z > 100 )
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, 0, 0.5f);    //ok speed of missile
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name.StartsWith("Level1enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            //Instantiate(explosion, transform.position, transform.rotation);
        }
        if (collision.gameObject.name.StartsWith("UFO"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            gameManager.UFODestroyed();
        }
    }
}
