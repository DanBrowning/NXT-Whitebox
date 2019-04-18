using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour {

    private float timer;
    public bool clockwise;

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 11)
        {
            timer = 0;

            if (clockwise)
                clockwise = false;
            else
                clockwise = true;
        }

        if (clockwise)
            transform.Rotate(0, .1f, 0);
        else if (!clockwise)
            transform.Rotate(0, -.1f, 0);

    }
}
