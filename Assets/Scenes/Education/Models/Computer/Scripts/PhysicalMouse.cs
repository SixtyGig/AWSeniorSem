using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalMouse : MonoBehaviour
{
    public GameObject physicalMouse;

    private float xPos = 0;
    private float yPos = 0;
    private float zPos = 0;

    Vector3 newPos;

    public int xPosBoundingCoordinate;
    public int xNegBoundingCoordinate;
    public int zPosBoundingCoordinate;
    public int zNegBoundingCoordinate;

    // Update is called once per frame
    void Update()
    {
        xPos = physicalMouse.transform.position.x;
        yPos = physicalMouse.transform.position.y;
        zPos = physicalMouse.transform.position.z;

        if (physicalMouse.transform.position.x > xPosBoundingCoordinate)
        {
            newPos = new Vector3(xPosBoundingCoordinate, yPos, zPos);
            physicalMouse.transform.position = newPos;
        }
        if (physicalMouse.transform.position.x < xNegBoundingCoordinate)
        {
            newPos = new Vector3(xNegBoundingCoordinate, yPos, zPos);
            physicalMouse.transform.position = newPos;
        }
        if (physicalMouse.transform.position.z > zPosBoundingCoordinate) 
        {
            newPos = new Vector3(xPos, yPos, zPosBoundingCoordinate);
            physicalMouse.transform.position = newPos;
        }
        if (physicalMouse.transform.position.z < zNegBoundingCoordinate)
        {
            newPos = new Vector3(xPos, yPos, zNegBoundingCoordinate);
            physicalMouse.transform.position = newPos;
        }
    }
}
