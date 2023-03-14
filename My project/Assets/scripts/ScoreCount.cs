using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{

    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text finalText;
    [SerializeField] int maxScores;

    //[SerializeField] coinappear creator;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    
    public void AddPoints(int amount)
    {
        //Change the score on colision with coin
        score += amount;
        scoreText.text = "Score: " + score;
        Debug.Log("New score: " + score);
    }
    

    private void DesplayGameOver()
    {
        finalText.text = "Game Over";
        scoreText.text = "";
    }

    private void DisplayWin()
    {
        finalText.text = "You Win";
        scoreText.text = "";
    }
    private void Update()
    {
        if (score >= maxScores)
        {
            DisplayWin();
            Time.timeScale = 0;
        }
        else if (score < 0)
        {
            DesplayGameOver();
            Time.timeScale = 0;
        }
    }
}