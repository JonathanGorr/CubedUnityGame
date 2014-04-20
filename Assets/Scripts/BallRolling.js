#pragma strict

function FixedUpdate () {

	if(Input.GetKey(KeyCode.DownArrow)){
		rigidbody.AddForce(-Vector3.forward*5);
}
	if(Input.GetKey(KeyCode.UpArrow)){
		rigidbody.AddForce(Vector3.forward*5);
}
	if(Input.GetKey(KeyCode.RightArrow)){
		rigidbody.AddForce(Vector3.right*5);
}
	if(Input.GetKey(KeyCode.LeftArrow)){
		rigidbody.AddForce(Vector3.left*5);
}
}