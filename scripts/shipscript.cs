using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shipscript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject missile;
    public GameObject explosion;
    int upgradecount;
    private int ufoCount = 8;
    private int ufoCount2 = 10;
    private int ufoCount3 = 1;
    public Text score;
    int score1;
    int score2;
    int score3;
    public float sceneDelay = 3f;
    void Start()
    {
        score1 = 0;
        score2 = 100;
        score3 = 1000;
        upgradecount = 0;
    }

    void Update()
    {
      

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (upgradecount == 0)
            {
                Vector3 v = transform.position;
                v.y = 2;
                v.x += 1.5f;
                GameObject.Instantiate(missile, v, transform.rotation);
            }
            else if (upgradecount == 1)
            {
                Vector3 v = transform.position;
                v.y = 2;
                v.x += 1.5f;
                GameObject.Instantiate(missile, v, transform.rotation);
                Vector3 v2 = transform.position;
                v2.y = 2;
                v2.x -= 1.5f;
                GameObject.Instantiate(missile, v2, transform.rotation);
            }
            else if (upgradecount == 2)
            {
                Vector3 v = transform.position;
                v.y = 2;
                v.x += 1.5f;
                GameObject.Instantiate(missile, v, transform.rotation);
                Vector3 v2 = transform.position;
                v2.y = 2;
                v2.x -= 1.5f;
                GameObject.Instantiate(missile, v2, transform.rotation);
                Vector3 v3 = transform.position;
                v3.y = 2;
                GameObject.Instantiate(missile, v3, transform.rotation);

            }
            else if (upgradecount >= 3)
            {
                Vector3 v = transform.position;
                v.y = 2;
                v.x += 1.5f;
                GameObject.Instantiate(missile, v, transform.rotation);
                Vector3 v2 = transform.position;
                v2.y = 2;
                v2.x -= 1.5f;
                GameObject.Instantiate(missile, v2, transform.rotation);
                Vector3 v3 = transform.position;
                v3.y = 2;
                v3.x += 0.5f;
                GameObject.Instantiate(missile, v3, transform.rotation);
                Vector3 v4 = transform.position;
                v4.y = 2;
                v4.x -= 0.5f;
                GameObject.Instantiate(missile, v4, transform.rotation);
            }
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x < 9f)
        {
            if (Input.GetKey(KeyCode.D))
            {

                GetComponent<Rigidbody>().AddForce(15, 0, 0);
            }
        }
        else
        {
            Vector3 vector3 = transform.position;
            vector3.x = 9f;
            transform.position = vector3;
        }

       
        if (transform.position.x > -9f)
        {   
            if (Input.GetKey(KeyCode.A))
            {      
                GetComponent<Rigidbody>().AddForce(-15, 0, 0);
            }
        }
        else
        {
            Vector3 vector3 = transform.position;
            vector3.x = -9f;
            transform.position = vector3;
        }

    }

    public void UFODestroyed()
    {
        ufoCount--;
        print(ufoCount);
        score1+= 10;
        score.text = "Score: " + score1.ToString();
        if (ufoCount < 2)
        {
            LoadNextScenedelay("a");
        }
    }
    public void UFODestroyed2()
    {
        ufoCount2--;
        print(ufoCount2);
        score2 += 50;
        score.text = "Score: " + score2.ToString();

        if (ufoCount2 < 3)
        {
            LoadNextScenedelay2("a");
        }
    }

    public void UFODestroyed3()
    {
        ufoCount3--;
        print(ufoCount3);
        score3 += 100;
        score.text = "Score: " + score3.ToString();
        if (ufoCount3 <= 0)
        {
            LoadNextScenedelay3("a"); 
        }
    }
    void LoadNextScenedelay(string sceneName)
    {
        Invoke("LoadNextScene", sceneDelay);
    }

    void LoadNextScenedelay2(string sceneName)
    {
        Invoke("LoadNextScene2", sceneDelay);
    }
    void LoadNextScenedelay3(string sceneName)
    {
        Invoke("LoadNextScene3", sceneDelay);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("SCENE1 ACT2"); 
    }

    void LoadNextScene2()
    {
        SceneManager.LoadScene("SCENE1 BOSS"); 
    }

    void LoadNextScene3()
    {
        SceneManager.LoadScene("WINEND");
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("enemyweapons"))
        {
            Debug.Log("Enemy missile hit the player!");
            // Handle damage or destruction logic here
            Destroy(collision.gameObject); // Destroy the missile
        }
        if(collision.gameObject.layer == LayerMask.NameToLayer("upgrade"))
        {
            Debug.Log("Upgrade collected!");
            upgradecount++;
            GameObject.Instantiate(explosion, transform.position, transform.rotation);
            Destroy(collision.gameObject);
        }
    }

}
