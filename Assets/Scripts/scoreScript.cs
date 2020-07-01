using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreScript : MonoBehaviour
{

    TextMeshProUGUI scoreText;
    public static double scoreResource;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreResource = 0;
    }

    // Update is called once per frame
    void Update()
    {
        FinalScoreScript.score = scoreResource;
        

        scoreText.text = "score   " + scoreResource.ToString("N0");
        //scoreText.text = gameManagerScript.enemyCounter.ToString();
    }
}
