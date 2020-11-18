using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MouseClick : MonoBehaviour
{
    [Header("SteamVR Input Sources")]
    public SteamVR_Input_Sources leftHand;
    public SteamVR_Input_Sources rightHand;


    // Update is called once per frame
    void Update()
    {
        //GrabGrip
        if (SteamVR_Input.GetStateDown("GrabGrip", leftHand))
        {
            Debug.Log("LeftHand GrabGrip");
        }
        if (SteamVR_Input.GetStateDown("GrabGrip", rightHand)) 
        {
        
        }

        // Trigger (Mouse Click)
    }
}
