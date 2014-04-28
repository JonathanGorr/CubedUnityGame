#pragma strict

function Update () {

	for (var state : AnimationState in animation) {
    	state.speed = 0.5;
	} 
	
	//if nothing is pressed, stand idle
	if(Input.anyKey == false)
	{
		animation.Play("Stand");
	}

	if(Input.GetKey("w")){
		//animation["Running"].speed = 1;
		animation.Play("Running");
	}
	else if(Input.GetKey("a")){
		animation.Play("Stand");
	}
	else if(Input.GetKey("d")){
		animation.Play("Stand");
	}
	else if(Input.GetKey("s")){
		//animation["Running"].speed = -1;
		//animation["Running"].time = animation["Running"].length;
		animation.Play("Running");
	}
	else
	{
		//animation.StopAll();
		animation.Play("Stand");
	}
}