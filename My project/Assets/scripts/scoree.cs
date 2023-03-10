using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoree : MonoBehaviour
{

    [SerializeField] TMP_Text tmpObj;
    [SerializeField] int maxScores;
    //[SerializeField] coinappear creator;
    int scores;
    // Start is called before the first frame update
    void Start()
    {
        scores = 0;
    }

    
    public void AddPoints(int amount)
    {
        //Change the score on colision with coin
        scores += amount;
        tmpObj.text = "Score: " + scores;
        Debug.Log("New score: " + scores);

        if (scores >= maxScores)
        {
            Finish();
        }
    }

    void Finish()
    {

        Time.timeScale = 0f;
        tmpObj.text += "\n\n YOU WON!!!";

}
}
