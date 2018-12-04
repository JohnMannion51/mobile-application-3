using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
    //use the levelManager
    public LevelManager levelManager;

    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update () {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "red")
        {
            levelManager.currentCheckpoint = gameObject;//resets the players current position to checkpoint when they die
            Debug.Log("Activated Checkpoint" + transform.position);//used to test checkpoint during development and testing
        }
    }
}
