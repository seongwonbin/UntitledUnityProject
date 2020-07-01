using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy2Script : MonoBehaviour
{
    protected Animator animator;
    private float speed = -0.03f;
    public static float enemy2HealthPoint = 500;
    private float yOffset = 0.05f;


    // Start is called before the first frame update
    void Start()
    {


        transform.position = new Vector3(13.0f, -1.0f, 0f);
        this.gameObject.tag = "EnemyTag";

        animator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {


        float randomSource = Random.Range(0.9f, 1.1f);

        transform.Translate(speed, yOffset, 0);
        if (transform.position.y >= 1)
            yOffset = 0;

        if (enemy2HealthPoint <= 0)
        {
            Debug.Log("enemy2destroy");
            Destroy(gameObject);
            enemy2HealthPoint = 1000;
            scoreScript.scoreResource += 2000 * randomSource;
        }

        monster2AttackScript.attackTimer = (monster2AttackScript.attackTimer % 120);

        if (monster2AttackScript.attackTimer == 119)
            statusScript.slHP.value -= 20;



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerTag")
        {
            speed = 0.0f;

            animator.SetBool("IsPlayerExist", true);
        }


    }


}
