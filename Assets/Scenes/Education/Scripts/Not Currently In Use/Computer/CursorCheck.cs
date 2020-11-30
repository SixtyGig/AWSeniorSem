using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorCheck : MonoBehaviour
{
    public GameObject computerCursor;

    private float xPos = 0;
    private float yPos = 0;
    private float zPos = 0;

    Vector3 newPos;

    public int xMaxBoundingCoordinate;
    public int xMinBoundingCoordinate;
    public int yMaxBoundingCoordinate;
    public int yMinBoundingCoordinate;

    // Update is called once per frame
    void Update()
    {
        //KeepCursorBound();

    }

    /*public void KeepCursorBound() 
    {
        xPos = computerCursor.transform.position.x;
        yPos = computerCursor.transform.position.y;
        zPos = computerCursor.transform.position.z;

        if (computerCursor.transform.position.x > xMaxBoundingCoordinate)
        {
            newPos = new Vector3(xMaxBoundingCoordinate, yPos, zPos);
            computerCursor.transform.position = newPos;
        }
        if (computerCursor.transform.position.x < xMinBoundingCoordinate)
        {
            newPos = new Vector3(xMinBoundingCoordinate, yPos, zPos);
            computerCursor.transform.position = newPos;
        }
        if (computerCursor.transform.position.z > yMaxBoundingCoordinate)
        {
            newPos = new Vector3(xPos, yMaxBoundingCoordinate, zPos);
            computerCursor.transform.position = newPos;
        }
        if (computerCursor.transform.position.z < yMinBoundingCoordinate)
        {
            newPos = new Vector3(xPos, yMinBoundingCoordinate, zPos);
            computerCursor.transform.position = newPos;
        }
    }*/
}
