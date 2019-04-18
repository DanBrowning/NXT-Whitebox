using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float moveSpeed;
    private Rigidbody _rb;

    private float timer;

    // Use this for initialization
    void Start ()
    {
        _rb = GetComponent<Rigidbody>();
        timer = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += Time.deltaTime * moveSpeed * transform.up;
        timer += Time.deltaTime;
        if (timer > 4)
        {
            Destroy(gameObject);
            timer = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "Enemy")
        //    Debug.Log("Enemy");
        Destroy(gameObject);
    }
}
