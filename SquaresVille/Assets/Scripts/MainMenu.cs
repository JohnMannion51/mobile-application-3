using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string startLevel;
    public string levelSelect;

    public void NewGame()
    {
        SceneManager.LoadScene("Tutorial");
        PlayerPrefs.SetInt("CurrentScore", 0);
    }

    

    public void QuitGame()
    {
        Debug.Log("Game Exited");
        Application.Quit();
    }
}
