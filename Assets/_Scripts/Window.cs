using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour {

    private Rigidbody _rb;

	// Use this for initialization
	void Start ()
    {
        _rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile" || collision.gameObject.tag == "Player")
        {
            Debug.Log("glass");
            _rb.AddForce(0, 0, -100000, ForceMode.Impulse);
        }
    }
}
