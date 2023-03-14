using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
/*
This script will make the score appear on the screen and will stop the game when the player gets 10 points.
It will also add points to the score.
Finally it will make the game over text when the score is less than 0. And it will make the you win text when the score is greater than 10.
By: Francisco Martinez Gallardo and Rafael Blanga
*/


public class ScoreCount : MonoBehaviour
{
    // Variable declaration
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text finalText;
    [SerializeField] int maxScores;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0; // set the score to 0 on the start of the game
    }

    
    public void AddPoints(int amount)
    {
        //Change the score on colision with and object
        score += amount;
        scoreText.text = "Score: " + score; // display the score on the screen
    }
    

    private void FinalDisplay(string text)
    {
        finalText.text = text; // display the text on the screen
        scoreText.text = ""; // remove the score from the screen
    }

    private void Update()
    {
        if (score >= maxScores)
        {
            FinalDisplay("You Win"); // display the you win text on the screen
            Time.timeScale = 0; // stop the game
        }
        else if (score < 0)
        {
            FinalDisplay("Game Over"); // display the game over text on the screen
            Time.timeScale = 0;// stop the game
        }
    }
}