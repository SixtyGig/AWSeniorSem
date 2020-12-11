using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpiPenManagement : MonoBehaviour
{
    private GameObject epiPen;
    private GameObject epiPenTip;


    private void Awake()
    {
        epiPen = GameObject.FindGameObjectWithTag("EpiPen");
        epiPenTip = GameObject.FindGameObjectWithTag("EpiPenTip");

    }
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
