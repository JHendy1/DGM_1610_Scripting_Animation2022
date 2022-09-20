using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; //keep track of score
    public TextMeshProUGUI scoreText; // Text UI object to be modified

    //Start is called before the first frame update
    private void Start()
    {
        UpdateScoreText(); //Call update score text
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount; //Increase score by amount
        UpdateScoreText(); //Update score UI text
    }
    public void DecreaseScoreText(int amount)
    {
        score -= amount; //Decrease score by amount
        UpdateScoreText(); //Update score UI text
    }
    public void UpdateScoreText()
    {
        scoreText.text = "Score:" + score;
    }

}
