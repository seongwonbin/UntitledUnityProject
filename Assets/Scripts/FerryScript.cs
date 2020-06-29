using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerryScript : MonoBehaviour
{

    public static bool isFerrying = false;


    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (monster2AttackScript.ferryTimer == false)
        { 
           isFerrying = false;
            Time.timeScale = 1f;
            Time.fixedDeltaTime = 1f;

            


        }
    }

    public void ferrybuttonScript()
    {
        if (monster2AttackScript.ferryTimer == true)
        {
            isFerrying = true;
            Time.timeScale = 1f;
            Time.fixedDeltaTime = 1f;
        }

    }
}
