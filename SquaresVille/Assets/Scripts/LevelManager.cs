using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckpoint;
    private PlayerController player;


    public GameObject deathParticle;
    public GameObject respawnParticle;
    public float respawnDelay;

    public int pointPenaltyOnDeath;
    private float gravityStore;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // Can be accessed by other scripts
    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }//RespawnPlayer

    public IEnumerator RespawnPlayerCo()
    {   //respawn and death particles along with the gravity scale are set in unity
        //if the player is killed or falls off the screen it activates the death particle 
        Instantiate(deathParticle, player.transform.position, player.transform.rotation);
        gravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
        player.GetComponent<Rigidbody2D>().gravityScale = 0f;
        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        Debug.Log("Player Respawn");//used to test respawn during development and testing
        yield return new WaitForSeconds (respawnDelay);
        player.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        player.transform.position = currentCheckpoint.transform.position;
        //if the player is killed or falls off the screen it resets player position to the checkpoint location 
        Instantiate(respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);

    }
}
