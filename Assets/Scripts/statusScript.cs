using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class statusScript : MonoBehaviour
{
    public static Slider slHP;
    Slider slTimer;
    float fSliderBarTime;



    // Start is called before the first frame update
    void Start()
    {
        slHP = GetComponent<Slider>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (slHP.value <= 0)
            transform.Find("Fill Area").gameObject.SetActive(false);
        else
            transform.Find("Fill Area").gameObject.SetActive(true);


        if(slHP.value > 0.0f)
        {
           
            slHP.value -= (float)(Time.deltaTime+0.01);
        }
        else
        {
            //Debug.Log("Time Over");
        }
    }
}
