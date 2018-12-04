using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    //declared variables for player control and jump movement
    private Rigidbody2D rb;
    public float moveSpeed = 5.0f;
    public float jumpHeight;
    public Transform groundCheck;
    public float groungCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    private bool doubleJump;

    // Use this for initialization
    void Start () {
        Debug.Log("Start");
        rb = GetComponent<Rigidbody2D>();

    }//start

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groungCheckRadius, whatIsGround);//player is in contact with the ground
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += Vector3.right * Time.deltaTime * moveSpeed;//player is moving left to right automatically

//#if UNITY_STANDALONE || UNITY_WEBPLAYER //used to inform unity to use touch controls
        if (grounded)
            doubleJump = false;

        if (Input.GetKeyDown(KeyCode.Space) && grounded)//using space bar to jump while in development and pc testing
        {
            //rb .velocity = new Vector2(0, jumpHeight);
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && !grounded)//using space bar to double jump while in development and pc testing
        {
            
            //rb.velocity = new Vector2(0, jumpHeight);
            Jump();
            doubleJump = true;
        }

//#endif       
    }//update

    public void Move(float moveInput)
    {

    }

    public void Jump()
    {
        //rb.velocity = new Vector2(0, jumpHeight);

        if (grounded)
        {
            rb .velocity = new Vector2(0, jumpHeight);//player can jump from groun position
            //Jump();
        }

        if (!doubleJump && !grounded)
        {
            rb.velocity = new Vector2(0, jumpHeight);
            //Jump();
            doubleJump = true;//allows player to double jump from ground platforms only 
        }
    }//Jump


}//PlayerController
