using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainScreenScript : MonoBehaviour
{
    private float cameraMove;
    private float cameraMove2;
    private float accel;
    private float accel2;
    public static bool buttonReady = false;
    public static float myResult = 1;
    public static float myResult2 = 1;
    // Start is called before the first frame update
    void Start()
    {
        cameraMove = 0.01f;
        myResult = 1;
        buttonReady = false;
    }

    // Update is called once per frame
   
    void Update()
    {

       
        if (myResult <= 0)
        {
            buttonReady = true;
            //Debug.Log("I'm ready");
        }
        else
        {
            cameraMove = 65 + accel;
            accel -= 0.275f;
            myResult = cameraMove / 500f;
            //Debug.Log(myResult);
            transform.Translate(0.0f, myResult, 0.0f);
        }



        /*
         if (cameraMove >= 0.1004f)
         { 
             buttonReady = true;
             Debug.Log("I'm ready");
         }
         else
         {

             */
        /*
        cameraMove = 5 * accel;
        accel += 0.0001f;
        transform.Translate(0.0f, cameraMove, 0.0f);
        */

    }

   
}
