using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    //declared variable and UI interface for unity canvas
    public static int score;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        //score = 0;
        score = PlayerPrefs.GetInt("CurrentScore");//gets the players current score
    }//start

    void Update()//updates the score
    {
        if (score < 0)
            score = 0;

        text.text = "" + score;
    }//update

    public static void AddPoints(int pointsToAdd)//adds points to the player score and carries the score through the game
    {
        score += pointsToAdd;
        PlayerPrefs.SetInt("CurrentScore",score);
    }//addPoints

    public static void Reset()//resets the score to zero 
    {
        score = 0;
        PlayerPrefs.SetInt("CurrentScore", score);
    }//reset

}//ScoreManager
