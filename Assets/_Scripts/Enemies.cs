using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour {

    public int nodeindex;
    public Transform[] Paths;
    
    public float speed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (nodeindex < Paths.Length)
        {
            //Move our position a step closer to the target.
            this.transform.position = Vector3.MoveTowards(this.transform.position, Paths[nodeindex].position, speed * Time.deltaTime);
            this.transform.right = (Paths[nodeindex].position - this.transform.position).normalized;
            //If we've reached the destination, move to the next one
            if (this.transform.position == Paths[nodeindex].position)
            {
                nodeindex++;
            }
        }
        else
        {
            nodeindex = 0;
        }
    }
}

