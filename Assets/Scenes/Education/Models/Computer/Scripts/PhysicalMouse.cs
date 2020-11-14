using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalMouse : MonoBehaviour
{
    public GameObject physicalMouse;
    public GameObject computerCursor;

    private float xPos = 0;
    private float yPos = 0;
    private float zPos = 0;

    Vector3 newPos;

    public float xMaxBoundingCoordinate;
    public float xMinBoundingCoordinate;
    public float zMaxBoundingCoordinate;
    public float zMinBoundingCoordinate;

    // Update is called once per frame
    void Update()
    {
        KeepMouseBound();

    }
    public void KeepMouseBound() 
    {
        xPos = physicalMouse.transform.position.x;
        yPos = physicalMouse.transform.position.y;
        zPos = physicalMouse.transform.position.z;

        if (physicalMouse.transform.position.x > xMaxBoundingCoordinate)
        {
            newPos = new Vector3(xMaxBoundingCoordinate, yPos, zPos);
            physicalMouse.transform.position = newPos;
        }
        if (physicalMouse.transform.position.x < xMinBoundingCoordinate)
        {
            newPos = new Vector3(xMinBoundingCoordinate, yPos, zPos);
            physicalMouse.transform.position = newPos;
        }
        if (physicalMouse.transform.position.z > zMaxBoundingCoordinate)
        {
            newPos = new Vector3(xPos, yPos, zMaxBoundingCoordinate);
            physicalMouse.transform.position = newPos;
        }
        if (physicalMouse.transform.position.z < zMinBoundingCoordinate)
        {
            newPos = new Vector3(xPos, yPos, zMinBoundingCoordinate);
            physicalMouse.transform.position = newPos;
        }
    }
}
