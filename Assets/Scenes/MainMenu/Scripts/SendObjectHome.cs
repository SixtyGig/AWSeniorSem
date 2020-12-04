using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendObjectHome : MonoBehaviour
{
    public Vector3 startingPosition;
    public Quaternion startingRotation;

    public void Start()
    {
        startingPosition = this.gameObject.transform.position;
        startingRotation = this.gameObject.transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ImportantObject")) // Checking if the object is tagged as an Important Object - Allows it to teleport back
        {
            this.gameObject.transform.position = startingPosition;
            this.gameObject.transform.rotation = startingRotation;
        }
    }
}
