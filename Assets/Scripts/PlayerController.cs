using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody _rb;
    public float Speed;
	// Use this for initialization
	void Start () {
        _rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float horisontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horisontal, vertical, 0f);
        _rb.AddForce (direction * Speed);      
	}
}
