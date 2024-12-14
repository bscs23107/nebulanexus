using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demon : MonoBehaviour
{

    public GameObject enemybullet;
    public GameObject explosion;
    public GameObject explosion1;
    private shipscript gameManager;


    int life;
    public GameObject upgrade;
    int num, num2;
    private bool DoOnce = false;
    private bool DoOnce2 = false;

    void Start()
    {
        gameManager = FindObjectOfType<shipscript>();
        life = 50;
        InvokeRepeating("Bulletspawn", 3f, 5f);
        InvokeRepeating("upgradespawn", 3f, 5f);

    }

    // Update is called once per frame
    void Update()
    {
        print(life);

        if (num == 1 && DoOnce == false)
        {
            Vector3 v = transform.position;
            v.y = 2;
            v.x += 1.5f;

            Vector3 v2 = transform.position;
            v.y = 2;
            v.x -= 1.5f;

            GetComponent<Animator>().Play("Attack");

            GameObject.Instantiate(enemybullet, v, transform.rotation);
            GameObject.Instantiate(enemybullet, v2, transform.rotation);
            DoOnce = true;
        }
        if (num2 == 1 && DoOnce2 == false)
        {
            Vector3 v = transform.position;
            v.y = 2;
            v.x += 1.5f;
            GameObject.Instantiate(upgrade, v, transform.rotation);
            DoOnce2 = true;
        }
    }


    private void FixedUpdate()
    {
        if(life <= 26 && life >= 23)
        {
            GetComponent<Animator>().Play("Angry");
        }
    }

    private void Bulletspawn()    // drops a bullet
    {
        num = Random.Range(0, 2);
        DoOnce = false;
    }

    private void upgradespawn()   // drops a upgrade 
    { 
       num2 = Random.Range(0,3);
       DoOnce2 = false;
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name.StartsWith("Missile"))
        {
            life--;
            GameObject.Instantiate(explosion, transform.position, transform.rotation);

            if (life <= 0)
            {
                Destroy(gameObject);
                GameObject.Instantiate(explosion1, transform.position, transform.rotation);
                gameManager.UFODestroyed3();

            }
            Destroy(collision.gameObject);

        }
    }
}
