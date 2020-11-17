using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalMouse : MonoBehaviour
{
    public GameObject physicalMouse;
    public GameObject computerCursor;

    // The Vector3 locations of both mouse and cursor
    public Vector3 mousePos;
    public Vector3 cursorPos;

    // Current coordinates of the Physical Mouse
    private float xPos_Mouse = 0;
    private float yPos_Mouse = 0;
    private float zPos_Mouse = 0;

    // New coordinates of the Physical Mouse
    private float xPosNew_Mouse = 0;
    private float zPosNew_Mouse = 0;

    // Current coordinates of the Computer Cursor
    private float xPos_Cursor = 0;
    private float yPos_Cursor = 0;
    private float zPos_Cursor = 0;

    // New coordinates of the Computer Cursor
    private float xPosNew_Cursor = 0;
    private float yPosNew_Cursor = 0;

    // The recorded distance in between the new and old coordinates
    private float xChange_Mouse = 0;
    private float zChange_Mouse = 0;

    public float xMaxBoundingCoordinate;
    public float xMinBoundingCoordinate;
    public float zMaxBoundingCoordinate;
    public float zMinBoundingCoordinate;

    // Update is called once per frame
    void Update()
    {
        CurrentMousePosition();
        CurrentCursorPosition();
        //KeepMouseBound();
        MoveComputerCursor();    
    }

    public void CurrentMousePosition() // Cursor moves along the X axis and Z axis, keeping track of Y to build a new Vector3 later
    {
        xPos_Mouse = physicalMouse.transform.position.x;
        yPos_Mouse = physicalMouse.transform.position.y;
        zPos_Mouse = physicalMouse.transform.position.z;
    }
    public void CurrentCursorPosition() // Cursor moves along the X axis and Y axis, keeping track of Z to build a new Vector3 later
    {
        xPos_Cursor = computerCursor.transform.position.x; 
        yPos_Cursor = computerCursor.transform.position.y; 
        zPos_Cursor = computerCursor.transform.position.z;
    }
    public float CalculateCoordinateChange(float oldPosition, float newPosition)
    {
        float change;

        if (newPosition > oldPosition)      // Change is positive
        {
            change = newPosition - oldPosition; 
        }
        else if (newPosition < oldPosition) // Change is negative
        {
            change = oldPosition - newPosition;
        }
        else                                // Position stays the same
        {
            change = 0f;
        }
            
        return change;
    }
    public void MoveComputerCursor() 
    {
        xPosNew_Mouse = physicalMouse.transform.position.x;
        zPosNew_Mouse = physicalMouse.transform.position.z;

        xChange_Mouse = CalculateCoordinateChange(xPos_Mouse, xPosNew_Mouse);
        zChange_Mouse = CalculateCoordinateChange(zPos_Mouse, zPosNew_Mouse);

        cursorPos = new Vector3((xChange_Mouse * 3), yPos_Cursor, (zChange_Mouse * 3));
    }
    
    /*public void KeepMouseBound() 
    {
        if (physicalMouse.transform.position.x > xMaxBoundingCoordinate)
        {
            mousePos = new Vector3(xMaxBoundingCoordinate, yPos_Mouse, zPos_Mouse);
            physicalMouse.transform.position = mousePos;
        }
        if (physicalMouse.transform.position.x < xMinBoundingCoordinate)
        {
            mousePos = new Vector3(xMinBoundingCoordinate, yPos_Mouse, zPos_Mouse);
            physicalMouse.transform.position = mousePos;
        }
        if (physicalMouse.transform.position.z > zMaxBoundingCoordinate)
        {
            mousePos = new Vector3(xPos_Mouse, yPos_Mouse, zMaxBoundingCoordinate);
            physicalMouse.transform.position = mousePos;
        }
        if (physicalMouse.transform.position.z < zMinBoundingCoordinate)
        {
            mousePos = new Vector3(xPos_Mouse, yPos_Mouse, zMinBoundingCoordinate);
            physicalMouse.transform.position = mousePos;
        }
    }*/
}
