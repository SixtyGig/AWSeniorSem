using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pencilTip : MonoBehaviour
{
    private GameObject pencilLeadObject;


    public void Awake()
    {
        pencilLeadObject = GameObject.FindGameObjectWithTag("PencilLead");

    }
    public void Start()
    {
        
    }
}
