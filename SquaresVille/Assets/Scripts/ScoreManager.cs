﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        score = 0;
    }//start

    void Update()
    {
        if (score < 0)
            score = 0;

        text.text = "" + score;
    }//update

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }//addPoints

    public static void Reset()
    {
        score = 0;
    }//reset

}//class