﻿using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour {
	
	//This controller includes a FauxGravityBody
	
	public float speed = 15;
	public float jumpSpeed = 5f;
	public float characterHeight = 2f;
	private Vector3 direction = Vector3.zero;
	public FauxGravityAttractor _FauxGravityAttractor; // Calls the attractor script
	private Transform myTransform;
	float jumpRest = 0.05f; // Sets the ammount of time to "rest" between jumps
	float jumpRestRemaining = 0; //The counter for Jump Rest
	
	RaycastHit hit;
	private float distToGround;
	
	void Start () {
		rigidbody.useGravity = false; // Disables Gravity
		rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
		myTransform = transform;
	}
	
	void Update() {
		jumpRestRemaining -= Time.deltaTime; // Counts down the JumpRest Remaining
		
		if (Physics.Raycast (transform.position, -transform.up, out hit)) {
			distToGround = hit.distance;
			Debug.DrawLine (transform.position, hit.point, Color.cyan);
		}
		
		if (Input.GetKeyDown("space") && distToGround < (characterHeight * .5) && jumpRestRemaining < 0) { // If the jump button is pressed and the ground is less the 1/2 the hight of the character away from the character:
			jumpRestRemaining = jumpRest; // Resets the jump counter
			rigidbody.AddRelativeForce (Vector3.up * jumpSpeed * 100); // Adds upward force to the character multitplied by the jump speed, multiplied by 100
			animation.Play ("Jumping");
		}
	}
	
	void FixedUpdate() {
		rigidbody.MovePosition(rigidbody.position + transform.TransformDirection(direction) * speed * Time.deltaTime);
		if (_FauxGravityAttractor){
			_FauxGravityAttractor.Attract(myTransform);
		}
	}
}