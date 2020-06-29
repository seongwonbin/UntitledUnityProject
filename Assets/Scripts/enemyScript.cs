using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyScript : MonoBehaviour
{
    protected Animator animator;
    private float speed = -0.03f;
    public static float enemyHealthPoint = 100;

    

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


        float randomSource = Random.Range(0.9f,1.1f);

        transform.Translate(speed, 0, 0);

        if (enemyHealthPoint <= 0)
        {
            Debug.Log("enemy1destroy");
            Destroy(gameObject);
           
            enemyHealthPoint = 100;
            scoreScript.scoreResource += 500 * randomSource;
        }

        monsterAttackScript.attackTimer = (monsterAttackScript.attackTimer % 100);

        if (monsterAttackScript.attackTimer == 99) 
            statusScript.slHP.value -= 2;


       



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PlayerTag")
        {
            speed = 0.0f;

            animator.SetBool("IsPlayerExist", true);
        }


    }


}
