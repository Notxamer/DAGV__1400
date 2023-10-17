using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Text Mesh Pro name spaced added to access librays for the UI

public class ScoreManager : MonoBehaviour
{
    public int score; //Keep Score value

    public TextMeshProUGUI scoreText;

    public void IncreaseScore()//Called to increase score

    {
        score ++;
        UpdateScoreText();
    }
    public void DecreaseScore() //Called to decrease score
    {
        score --;
        UpdateScoreText();
    }
    public void UpdateScoreText()// Updates score on the UI
    {
        scoreText.text = "Score: " + score;
    }
}
