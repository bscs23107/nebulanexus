using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class UFO2 : MonoBehaviour
{
    public GameObject explosion;
    public GameObject enemybullet;
    int life;
    private shipscript gameManager;

    // public GameObject upgrade;
    int num , num2;
    private bool DoOnce = false;
    private bool DoOnce2 = false;
  

    void Start()
    {
        gameManager = FindObjectOfType<shipscript>();
        life = 4;
        InvokeRepeating("Bulletspawn", 3f, 5f);
       // InvokeRepeating("upgradespawn", 3f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if( num == 1 && DoOnce == false)
        {
            Vector3 v = transform.position;
            v.y = 2;
            v.x += 1.5f;
            
            
            GameObject.Instantiate(enemybullet, v, transform.rotation);
            DoOnce = true;
        }
        //if(num2 == 1 && DoOnce2 == false)
        //{
        //    Instantiate(upgrade, transform.position, transform.rotation);
        //    DoOnce2 = true;
        //}


    }


    private void FixedUpdate()
    {
    }

    private void Bulletspawn()    // drops a bullet
    {
        num = Random.Range(0,4);
        DoOnce = false;
    }

    //private void upgradespawn()   // drops a upgrade 
    //{
    //    num2 = Random.Range(0, 20);
    //    DoOnce2 = false;
    //}


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name.StartsWith("Missile"))
        {
            
            life--;
            if (life <= 0)
            {
                Destroy(gameObject);
                Instantiate(explosion, transform.position, transform.rotation);
                gameManager.UFODestroyed2();
            }
            Destroy(collision.gameObject);

        }
    }
}
