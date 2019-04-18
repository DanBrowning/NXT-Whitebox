using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperRifle : MonoBehaviour {

    public Transform snipeSight;
    public LineRenderer myLine;
    float maxDist = 11;
    // Use this for initialization
    void Start ()
    {
        //Ray SnipeLine = new Ray(transform.position, transform.right);
    }
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;
        myLine.SetPosition(0, Vector3.zero);

        if (Physics.Raycast(transform.position, transform.right, out hit, Mathf.Infinity))
        {

            myLine.SetPosition(1, transform.InverseTransformPoint( hit.point));

        }
        else
        {
            myLine.SetPosition(1,  transform.right * maxDist);

        }
        //Physics.Raycast(snipeSight.position, Vector3.right);
        //Debug.DrawLine(snipeSight.position, Vector3.forward, Color.red);
        //Debug.DrawRay(snipeSight.localPosition, Vector3.left, Color.blue);
    }
}
