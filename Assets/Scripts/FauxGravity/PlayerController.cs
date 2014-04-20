using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 15;
	public float jumpSpeed = 10;
	private Vector3 moveDir;

	void Update () {
		moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

		//transform.rotation = Quaternion.LookRotation(moveDir);
	}

	void FixedUpdate() {
		rigidbody.MovePosition (rigidbody.position + transform.TransformDirection(moveDir) * moveSpeed * Time.deltaTime);

		if (Input.GetKeyDown("W")) {
						animation.Play ("Running");
				}
	}
}
