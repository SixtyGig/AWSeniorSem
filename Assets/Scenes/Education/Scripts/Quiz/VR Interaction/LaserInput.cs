using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserInput : MonoBehaviour
{
    public GameObject currObject;
    private int currID;
    private string tag;

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

                if ((currObject.name == "Button A") && (currObject.tag == "Button")) // Could check against the name as well, but tags are less likely to be changed
                {
                    Debug.Log("Button A has been hit");
                }
            }
        }
    }
}
