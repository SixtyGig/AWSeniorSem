using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homing : MonoBehaviour
{
    private Vector3 pos;
    private Quaternion rot;
    // Start is called before the first frame update

    void Start()
    {
        pos = this.transform.position;
        rot = this.transform.rotation;
    } 

    void GoHome() 
    {
        this.gameObject.transform.position = pos;
        this.gameObject.transform.rotation = rot;
    }
}
