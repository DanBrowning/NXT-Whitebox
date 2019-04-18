using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour {

    public int nodeindex;
    public Transform[] Paths;
    
    public float speed;
    private Rigidbody _rb;
    public bool doesMove;
    public bool alive;
    public bool isCarrying;
    public bool Assaulter;

    // Use this for initialization
    void Start ()
    {
        alive = true;
        _rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (doesMove)
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


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Projectile")
        {
            doesMove = false;
            _rb.useGravity = true;
            _rb.freezeRotation = false;
            if(alive)
            _rb.AddForce(Vector3.one, ForceMode.Impulse);
            alive = false;
            if (isCarrying)
            {
                transform.GetChild(0).GetChild(0).GetComponent<Rigidbody>().isKinematic = false;
                transform.GetChild(0).GetChild(0).GetComponent<BoxCollider>().enabled = true;
                transform.GetChild(0).GetChild(0).GetComponent<Rigidbody>().useGravity = true;

                if (Assaulter)
                {
                    transform.GetChild(0).GetChild(1).GetComponent<Rigidbody>().isKinematic = false;
                    transform.GetChild(0).GetChild(1).GetComponent<BoxCollider>().enabled = true;
                    transform.GetChild(0).GetChild(1).GetComponent<Rigidbody>().useGravity = true;
                }

                transform.GetChild(0).DetachChildren();
            }

            isCarrying = false;
        }
    }

}

