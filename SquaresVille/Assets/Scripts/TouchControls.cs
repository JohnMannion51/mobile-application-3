using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour {
    //using methods from PlayerController and PauseMenu
    private PlayerController thePlayer;
    private PauseMenu thePauseMenu;
	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        thePauseMenu = FindObjectOfType<PauseMenu>();
	}
	
	public void Jump()
    {
        thePlayer.Jump();//the player hits the jump button
    }

    public void Pause()
    {
        thePauseMenu.PauseUnpause();//the player hits the pause button
    }
}
