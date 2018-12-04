using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public bool isPaused;//determine state if paused

    public GameObject pauseMenuCanvas;//pause menu canvas
	
	// Update is called once per frame
	void Update () {
		if(isPaused)
        {
            pauseMenuCanvas.SetActive(true);//if paused time scale gets set to 0
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);//once resumed time is set to 1
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))//uses escape key to pause
        {
            PauseUnpause();
        }
	}

    public void PauseUnpause()
    {
        isPaused = !isPaused;//pauses game
    }
    public void Resume()
    {
        isPaused = false;//resumes game
    }

    public void QuitGame()
    {
        Debug.Log("Game Exited");//exits the game with log in the console for testing
        Application.Quit();//quits the application
    }
}
