using UnityEngine;
using System.Collections;

public class rotateCube : MonoBehaviour
{
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	
	
	void Update ()
	{
		if(Input.GetKey(KeyCode.UpArrow))
			transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.DownArrow))
			transform.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
	}
}