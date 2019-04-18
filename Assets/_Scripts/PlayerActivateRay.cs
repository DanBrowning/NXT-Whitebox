using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActivateRay : MonoBehaviour {

    public Transform snipeSight;
    public LineRenderer myLine;
    float maxDist = 20;

    // Use this for initialization
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;
        myLine.SetPosition(0, Vector3.zero);

        if (Physics.Raycast(transform.position, transform.right, out hit, Mathf.Infinity))
        {

            myLine.SetPosition(1, transform.InverseTransformPoint(hit.point));

        }
        else
        {
            myLine.SetPosition(1, transform.right * maxDist);

        }
    }
}
