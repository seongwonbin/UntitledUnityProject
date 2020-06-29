using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    protected Animator animator;

    public int attackCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (gameManagerScript.enemyCounter == false)
                animator.SetBool("IsEnemyExist", false);

        
        BasicAttackScript.attackTimer = (BasicAttackScript.attackTimer % 60);

        if (BasicAttackScript.attackTimer == 59)
        {
            if (gameManagerScript.evilEyeCounter > 10)
                enemyScript.enemyHealthPoint -= 30;

            else if (gameManagerScript.evilEyeCounter <= 10 && gameManagerScript.evilEyeCounter > 0)
                enemy2Script.enemy2HealthPoint -= 30;
            else
                Debug.Log("hoohoholooo");
        }


        if (FerryScript.isFerrying == true)
            animator.SetBool("FerryBool" , true);

        else 
            animator.SetBool("FerryBool", false);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyTag")
        {
            animator.SetBool("IsEnemyExist", true);
           // Debug.Log(attackcounter++);
        }
       





    }

}
