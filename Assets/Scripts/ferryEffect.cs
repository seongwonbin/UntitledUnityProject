using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ferryEffect : MonoBehaviour
{

    public GameObject obj;
    private float xPos = 20.0f;
   // private float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-6.1f, -1.3f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xPos*Time.deltaTime, 0.0f, 0.0f);


        //if (xPos*speed >= 120)
       //     Destroy(gameObject);
       
    }
}
