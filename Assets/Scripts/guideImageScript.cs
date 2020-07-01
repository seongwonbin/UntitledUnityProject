using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guideImageScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.localPosition = Vector3.zero;

       // transform.position = new Vector3(-407.16f, 80.95f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (guideButtonScript.guideImage == false)
            Destroy(gameObject);
    }

    public void buttonImagefunc()
    {
        guideButtonScript.guideImage = false;


    }
}
