using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homing : MonoBehaviour
{
    public Vector3 pos;
    public Quaternion rot;

    // Start is called before the first frame update
    public void Start() // Recording the original orientation of an object
    {
        pos = this.transform.position;
        rot = this.transform.rotation;
    } 

    public void GoHome()
    {
        this.gameObject.transform.position = pos;
        this.gameObject.transform.rotation = rot;
    }
}
