using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public string startLevel;
    public string levelSelect;

    public void NewGame()
    {
        Application.LoadLevel("Tutorial");
    }

    public void LevelSelect()
    {

    }

    public void quitGame()
    {
        Application.Quit();
    }
}
