using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendObjectHome : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ImportantObject") 
        {
            //other.GetComponent<homing>.SendHome();
        }
    }
}
