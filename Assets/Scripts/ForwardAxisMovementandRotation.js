#pragma strict

var speed : float = 0.2;
var TurnSpeed : float = 2.0;

function LateUpdate () {
	
	//if nothing is pressed, stand idle
	if(Input.anyKey == false)
	{
	}
	
	//movement & rotation
	if(Input.GetKey("w"))
	{
		this.transform.position += this.transform.forward * this.speed;
	}
	if(Input.GetKey("s"))
	{
		this.transform.position -= this.transform.forward * this.speed;
	}
	if(Input.GetKey("a"))
	{
		this.transform.Rotate(0,-this.TurnSpeed ,0);
	}
	if (Input.GetKey("d"))
	{
		this.transform.Rotate(0, this.TurnSpeed, 0);
	}
	if (Input.GetKey("space"))
	{
		
	}
	
	//animation slowdown
	for (var state : AnimationState in animation) {
    state.speed = 0.5;
} 
}