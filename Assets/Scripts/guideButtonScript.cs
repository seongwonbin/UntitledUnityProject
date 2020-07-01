using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class guideButtonScript : MonoBehaviour
{
    private float buttonMove;
    private float accel;
    private float myResult = 1f;
    private bool buttonStop = false;
    public GameObject obj;
    public static bool guideImage = false;


    public GameObject uiRoot;
    
    // Start is called before the first frame update
    void Start()
    {
      //  transform.position = new Vector3(-407.16f, -19.17f, 0f);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (mainScreenScript.buttonReady == true && buttonStop == false && mainButtonScript.myResultBS <= 3)
        {
            buttonMove = 200 + accel;
            accel -= 1f;
            myResult = buttonMove / 15f;
            //Debug.Log(myResult);
            transform.Translate(myResult, 0.0f, 0.0f);


        }

        if (myResult <= 0)
        {
            buttonStop = true;

        }

        if(mainButtonScript.activeMove == true)
            transform.position = new Vector3(-407.16f, -19.17f, 0f);

    }

    public void guideButton()
    {
        guideImage = true;
        //Instantiate(obj, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        GameObject child = Instantiate(obj, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
        child.transform.parent = gameObject.transform;


    }
}
