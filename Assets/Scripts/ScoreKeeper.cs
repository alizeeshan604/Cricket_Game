using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ScoreKeeper : MonoBehaviour
{
    public int score;
    public Text scoreboard;

    
    public void AddSixRuns()
    {
        score = score + 6;
        scoreboard.text = score.ToString();
    }

   
    public void AddFourRuns()
    {
        score = score + 4;
        scoreboard.text = score.ToString();
    }

    
    public void AddOneRun()
    {
        score = score + 1;
        scoreboard.text = score.ToString();
    }

    
    public void AddTwoRuns()
    {
        score = score + 2;
        scoreboard.text = score.ToString();
    }

    
    public void AddThreeRuns()
    {
        score = score + 3;
        scoreboard.text = score.ToString();
    }

 
    public void Wicket()
    {
        score = 0;
        scoreboard.text = score.ToString();
        //Time.timeScale = 0f;
        SceneManager.LoadScene("MainMenuScene");
    }



}
