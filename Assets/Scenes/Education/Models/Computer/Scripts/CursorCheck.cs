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

    public int xPosBoundingCoordinate;
    public int xNegBoundingCoordinate;
    public int yPosBoundingCoordinate;
    public int yNegBoundingCoordinate;

    // Update is called once per frame
    void Update()
    {
        xPos = computerCursor.transform.position.x;
        yPos = computerCursor.transform.position.y;
        zPos = computerCursor.transform.position.z;

        if (computerCursor.transform.position.x > xPosBoundingCoordinate)
        {
            newPos = new Vector3(xPosBoundingCoordinate, yPos, zPos);
            computerCursor.transform.position = newPos;
        }
        if (computerCursor.transform.position.x < xNegBoundingCoordinate)
        {
            newPos = new Vector3(xNegBoundingCoordinate, yPos, zPos);
            computerCursor.transform.position = newPos;
        }
        if (computerCursor.transform.position.z > yPosBoundingCoordinate)
        {
            newPos = new Vector3(xPos, yPosBoundingCoordinate, zPos);
            computerCursor.transform.position = newPos;
        }
        if (computerCursor.transform.position.z < yNegBoundingCoordinate)
        {
            newPos = new Vector3(xPos, yNegBoundingCoordinate, zPos);
            computerCursor.transform.position = newPos;
        }
    }
}
