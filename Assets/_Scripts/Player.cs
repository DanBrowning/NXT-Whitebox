using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject Projectile1;
    public Transform ProjSpawn;
    public Transform ProjRot;

    public bool climbable;

    public Transform spawnUpper;
    public Transform spawnLower;

    public float timer;
    public bool started;


    // Use this for initialization
    void Start ()
    {
        started = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Sound_Manager.instance.playSound(Sound_Manager.instance.fireSound);
            Instantiate(Projectile1, ProjSpawn.position, ProjRot.rotation);
            Debug.Log("Proj Fire");
        }
          
        
        if (climbable)
        {
            transform.Translate(0, 0.3f, 0); 
        }

        timer += Time.deltaTime;
        Debug.Log(timer);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ladder")
        {
            if (Input.GetMouseButtonDown(1))
            {
                
                climbable = true;
            }
        }

        if (other.gameObject.tag == "B1")
        {
            //Sound_Manager.instance.playSound(Sound_Manager.instance.elevatorSound);

            if (!started)
            {
                timer = 0;
                started = true;
            }
            if (timer > 5)
            {
                transform.position = spawnUpper.position;
                started = false;
            }
        }

        if (other.gameObject.tag == "3F")
        {
            //Sound_Manager.instance.playSound(Sound_Manager.instance.elevatorSound);
            if (!started)
            {
                timer = 0;
                started = true;
            }
            if (timer > 5)
            {
                transform.position = spawnLower.position;
                started = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "LadderTop")
        {
            Debug.Log("LadderTop");
            transform.Translate(0, 0, 1f);
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ladder")
        {
            climbable = false;
        }
    }
}
