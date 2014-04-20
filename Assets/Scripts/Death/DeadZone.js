#pragma strict

var SpawnPoint: Transform;

var player: GameObject;

function OnTriggerEnter (col : Collider)
{

	if(col.tag == "Player")
	{
		player.transform.position = SpawnPoint.position;
		Debug.Log("You Died!");
	}
}