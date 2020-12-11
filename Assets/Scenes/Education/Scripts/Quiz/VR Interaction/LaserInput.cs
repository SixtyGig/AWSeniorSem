using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class LaserInput : MonoBehaviour
{
    public SteamVR_Input_Sources leftHand;
    public SteamVR_Input_Sources rightHand;

    private GameObject currObject;
    private int currID;

    // Start is called before the first frame update
    private void Start()
    {
        currObject = null;
        currID = -1;
    }

    // Update is called once per frame
    private void Update()
    {
        RaycastHit[] hits = Physics.RaycastAll(transform.position, transform.forward, 100.0f);

        for (int i = 0; i < hits.Length; i++) 
        {
            RaycastHit hit = hits[i];

            int id = hit.collider.gameObject.GetInstanceID();

            if (currID != id) 
            {
                currID = id;
                currObject = hit.collider.gameObject;

                if (currObject.tag == "Button") // Could check against the name as well, but tags are less likely to be changed
                {
                    if (SteamVR_Input.GetStateDown("GrabGrip", leftHand))
                    {
                        Debug.Log(currObject.name + " has been pressed");
                        currObject.GetComponent<Button>().onClick.Invoke();
                    }
                    else if (SteamVR_Input.GetStateDown("GrabGrip", rightHand)) 
                    {
                        Debug.Log(currObject.name + " has been pressed");
                        currObject.GetComponent<Button>().onClick.Invoke();
                    }
                }
            }
        }
    }
}
