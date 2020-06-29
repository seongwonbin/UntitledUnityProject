
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cameraShake : MonoBehaviour
{
    public GameObject player;
    public float ShakeAmount;
    float ShakeTime;
    Vector3 initialPosition;
    public static Camera myCam;

    

    public void VibrateForTime(float time)
    {
        ShakeTime = time;
    }

    // Start is called before the first frame update
    void Start()
    {
        

        


        initialPosition = new Vector3(0f, 0f, -5f);

        myCam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ShakeTime > 0)
        {
            transform.position = Random.insideUnitSphere * ShakeAmount + initialPosition;
            ShakeTime -= Time.deltaTime;
        }
        else
        {
            ShakeTime = 0.0f;
            transform.position = initialPosition;
        }

        if (PlayerFerryScript.ferryEffect == true)
        { 
            VibrateForTime(0.3f);
            
        }

        Zoom();
        
    }

    private void Zoom()
    {
        Vector3 offset = gameObject.transform.position;

        offset.x -= 1.5f;
        //offset.y -= 0.75f;



        if (FerryScript.isFerrying == true)
        {
            //gameObject.transform.position = offset;

            myCam.orthographicSize -= 0.01f;    
        }




    }
}
