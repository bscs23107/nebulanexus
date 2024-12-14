using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemymissile : MonoBehaviour
{
    //public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(90, 0, 0);
    }



    private void Update()
    {
        if (transform.position.z < -100)
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, -0.2f, 0);    //calibrtion of the missile is weird thus work accordingly 

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            //Debug.Log("Missile hit the player!");
            //// Handle explosion, damage, or effects here
            //Destroy(collision.gameObject); // Destroy the player ship on collision
            SceneManager.LoadScene("LOSEEND");
            print("turn to game over screen ");
        }

    }
}
