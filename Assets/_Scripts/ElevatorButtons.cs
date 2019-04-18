using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButtons : MonoBehaviour
{

    private Material _mat;
    public Material On;
    public Material Off;


	// Use this for initialization
	void Start ()
    {
        _mat = GetComponent<Renderer>().material;

    }
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log(_mat.name);
    }

    public void on()
    {        
        _mat.color = Color.green;
    }

    public void off()
    {
        _mat.color = Color.black;
    }


}
