#pragma strict

var destination : Transform;
 
function OnTriggerEnter(other : Collider) {
    other.transform.position = destination.position;
    
    
}