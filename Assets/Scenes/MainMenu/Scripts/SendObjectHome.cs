using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendObjectHome : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ImportantObject")) // Checking if the object is tagged as an Important Object
        {
            // If true and the object has the "Homing.cs" script attached, reset the object to it's original "home" location
            if(other.GetComponent<Homing>() != null) 
            {
                other.GetComponent<Homing>().GoHome();
            }
        }
    }
}
