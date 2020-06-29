using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerScript : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    public Camera myCam;

    public static bool enemyCounter = false;
    public static int evilEyeCounter = 13;
    public static bool secondRound = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (enemyCounter == false)
            CreateEnemy();
        
        
        Collider2D clickColl = null;
        Vector3 worldPos;
        Vector2 clickPos;

        

        if (enemyScript.enemyHealthPoint <= 0 )
        {
            statusScript.slHP.value += 10;
            enemyCounter = false;
            Debug.Log("slhp value +10 // enemy1");
        }

        if (enemy2Script.enemy2HealthPoint <= 0)
        {
            statusScript.slHP.value += 10;
            enemyCounter = false;
            Debug.Log("slhp value +10 // enemy2");
        }


        if (Input.GetMouseButtonDown(0))
        {
            worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickPos = new Vector2(worldPos.x, worldPos.y);
            clickColl = Physics2D.OverlapPoint(clickPos);

            try
            {
                if (clickColl.gameObject.tag == "FerryTag")
                {
                   // Debug.Log("mouseTest");
                    


                }

                else if (clickColl.gameObject.tag == "ExitTag")
                {
                    //Debug.Log("Whaaat??"); 
                }
            }
            catch (NullReferenceException ex) // Not Tag
            { 
                Debug.Log(ex);
                //Debug.Log("?");
            }



        } // MouseButtonDown



        if (PlayerFerryScript.ferryEffect == true)
        {
            //Debug.Log("yposposition");
            Instantiate(obj3, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            enemy2Script.enemy2HealthPoint -= 500;
            PlayerFerryScript.ferryEffect = false;


        }



        if (evilEyeCounter == 10)
            enemyScript.enemyHealthPoint = 0;

    }

    void CreateEnemy()
    {
        if (evilEyeCounter > 10)
        {
            Debug.Log("enemy1create");
            Instantiate(obj, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            //enemyScript.enemyHealthPoint = 100;
            enemyCounter = true;
            evilEyeCounter -= 1;
        }
        else if (evilEyeCounter <= 10 && evilEyeCounter > 0)
        {
            Debug.Log("enemy2create");
            Instantiate(obj2, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            //enemyScript.enemyHealthPoint = 100;
            enemy2Script.enemy2HealthPoint = 300;
            enemyCounter = true;
            evilEyeCounter -= 1;
                
        }
        else
            Debug.Log("HI");

 


        


    }

}
