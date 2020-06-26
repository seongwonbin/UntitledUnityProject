using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyScript : MonoBehaviour
{

    private float speed = -0.03f;
    public float healthPoint = 100;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(13.0f, -1.0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PlayerTag")
        {
            speed = 0.0f;
        }

    }
}
