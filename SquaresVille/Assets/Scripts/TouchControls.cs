using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour {

    private PlayerController thePlayer;
    private PauseMenu thePauseMenu;
	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        thePauseMenu = FindObjectOfType<PauseMenu>();
	}
	
	public void Jump()
    {
        thePlayer.Jump();
    }

    public void Pause()
    {
        thePauseMenu.PauseUnpause();
    }
}
