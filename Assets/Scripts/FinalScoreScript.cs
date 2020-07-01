using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScoreScript : MonoBehaviour
{

    TextMeshProUGUI scoreText;
    public static double score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "score   " + score.ToString("N0");
    }
}
