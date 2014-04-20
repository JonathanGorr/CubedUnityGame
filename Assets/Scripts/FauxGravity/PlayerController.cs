using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 15;
	public float jumpSpeed = 10;
	private Vector3 moveDir;
	//private Vector3 dir;

	void Update () {
		moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
	}

	void FixedUpdate() {
		rigidbody.MovePosition (rigidbody.position + transform.TransformDirection(moveDir) * moveSpeed * Time.deltaTime);

	}

}
