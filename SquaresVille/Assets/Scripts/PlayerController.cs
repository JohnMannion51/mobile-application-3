using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

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
        grounded = Physics2D.OverlapCircle(groundCheck.position, groungCheckRadius, whatIsGround);
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        if (grounded)
            doubleJump = false;

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            //rb .velocity = new Vector2(0, jumpHeight);
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && !grounded)
        {
            //rb.velocity = new Vector2(0, jumpHeight);
            Jump();
            doubleJump = true;
        }
    }//update

    public void Jump()
    {
        rb.velocity = new Vector2(0, jumpHeight);
    }//Jump


}//PlayerController
