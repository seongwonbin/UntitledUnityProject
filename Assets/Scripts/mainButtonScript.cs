using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainButtonScript : MonoBehaviour
{
    private float buttonMove;
    private float accel;
    public static float myResultBS = 1f;
    private bool buttonStop = false;
    public static bool guideButton = false;
    public static bool activeMove = false;
    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector3(-407.16f, -19.17f, 0f);
        guideButton = false;
        activeMove = false;
        buttonStop = false;
        myResultBS = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        if (mainScreenScript.buttonReady == true && buttonStop == false)
        {
            buttonMove = 200 + accel;
            accel -= 1f;
            myResultBS = buttonMove / 15f;
            //Debug.Log(myResult);
            transform.Translate(myResultBS, 0.0f, 0.0f);


        }

        if (myResultBS <= 0)
        {
            buttonStop = true;

        }

        if (myResultBS <= 3)
            guideButton = true;

        if (activeMove == true)
        {
            transform.position = new Vector3(-407.16f, -19.17f, 0f);

        }




    }
    

    public void mainScreenButton()
    {
    SceneManager.LoadScene("MainField");

}
}
