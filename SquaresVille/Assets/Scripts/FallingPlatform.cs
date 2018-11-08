using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour {

    Rigidbody2D rb2d;
    //public float FallDelay;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }
    void onCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("red"))
        {
            Invoke("dropPlatform", 0.2f);
            Destroy(gameObject, 2f);
        }
        Debug.Log(col.collider.tag);
    }

    void dropPlatform()
    {

        rb2d.isKinematic = false;

    }
    /*void OnCollisonEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("red"))
        {
            StartCoroutine("Fall");
        }

    }
    IEnumerator Fall()
    {
        yield return new WaitForSeconds(FallDelay);
        rb2d.isKinematic = false;
        yield return 0;
    }
    public Collider coll;

    void Start()
    {
        coll = GetComponent<Collider>();
        coll.isTrigger = true;
    }

    // Disables gravity on all rigidbodies entering this collider.
    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = false;
    }



    void OnCollisonEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("red"))
        {
            StartCoroutine("Fall");
        }
        
    }
    IEnumerator Fall()
    {
        yield return new WaitForSeconds(FallDelay);
        rb2d.isKinematic = false;
        yield return 0;
    }

    void onCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("red"))
        {
            Invoke("dropPlatform", 0.5f );
            Destroy(gameObject, 2f);
        }
        Debug.Log(col.collider.tag);
    }

   void dropPlatform()
    {
        
        rb2d.isKinematic = false;

    }*/
}
