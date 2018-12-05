using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
    //declared variables and arrays
    public GameObject platform;
    public float moveSpeed;
    public Transform currentPoint;
    public Transform[] points;
    public int pointSelection;
    // Use this for initialization
	void Start () {
        currentPoint = points[pointSelection];
	}//start
	
	// Update is called once per frame
	void Update () {//updates the platforms position and moves between the two points
        platform.transform.position = Vector3.MoveTowards(platform.transform.position,
                                        currentPoint.position, Time.deltaTime * moveSpeed);

        if(platform.transform.position == currentPoint.position)
        {
            pointSelection++;

            if(pointSelection == points.Length)
            {
                pointSelection = 0;
            }//inner if

            currentPoint = points[pointSelection];
        }//outer if

	}//update

}//movingPlatform
