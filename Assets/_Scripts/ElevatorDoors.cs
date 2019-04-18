using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoors : MonoBehaviour {

    //public float speed;

    //public Transform Origin;

    public bool closing;
    public bool broken;

    // Use this for initialization
    void Start ()
    {
        
	}

    // Update is called once per frame
    void Update()
    {

        if (closing)
        {            
            //Sound_Manager.instance.playSound(Sound_Manager.instance.elevator);

            if (gameObject.tag == "LeftDoor")
            {
                transform.Translate(0, 0, 0.1f);

                if (transform.position.z >= -39.762f)
                {
                    closing = false;
                }
            }

            else if (gameObject.tag == "RightDoor")
            {
                transform.Translate(0, 0, -0.1f);

                if (transform.position.z <= -38.2631f)
                {
                    closing = false;
                }
            }
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            open();
            closing = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            close();
        }
    }


    private void open()
    {
        /*if (broken)
            Sound_Manager.instance.playSound(Sound_Manager.instance.bElevator);
        else
            Sound_Manager.instance.playSound(Sound_Manager.instance.elevator);*/
        if (gameObject.tag == "LeftDoor")
        {
            if (transform.position.z >= -41.22f)
            {
                transform.Translate(0, 0, -0.01f);
            }
        }
        else if (gameObject.tag == "RightDoor")
        {
            if (transform.position.z <= -36.8f)
            {
                transform.Translate(0, 0, 0.01f);
            }
        }
    }

    private void close()
    {
        closing = true;
    }
}
