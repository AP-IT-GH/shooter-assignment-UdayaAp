using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int HitScore = 50;
    public int score;
    public Text ScoreUI ;

    private void Start()
    {
        ScoreUI.text = "Score:" + score.ToString();
    }

    public void AddScore()
    {
        score = score + HitScore;

        ScoreUI.text = "Score:" + score.ToString();
    }

}  
