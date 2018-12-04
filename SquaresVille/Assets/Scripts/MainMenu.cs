using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    //declared variables
    public string startLevel;
    public string levelSelect;

    public void NewGame()
    {
        SceneManager.LoadScene("Tutorial");//new game button loads first scene
        PlayerPrefs.SetInt("CurrentScore", 0);//sets the score to 0
    }

    

    public void QuitGame()
    {
        Debug.Log("Game Exited");//used to test button during development and testing
        Application.Quit();//quits the application
    }
}
