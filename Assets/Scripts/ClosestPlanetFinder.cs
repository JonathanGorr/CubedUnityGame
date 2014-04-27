using UnityEngine;
using System.Collections;

public class ClosestPlanetFinder : MonoBehaviour {

	public FauxGravityAttractor Planet01;
	public FauxGravityAttractor Planet02;
	public Jumping jumping;

	// Update is called once per frame
	void Update () {
		Vector3 distance01 = transform.position - Planet01.gameObject.transform.position;
		Vector3 distance02 = transform.position - Planet02.gameObject.transform.position;
	
	if (distance01.magnitude < distance02.magnitude) {
						jumping._FauxGravityAttractor = Planet01;
				} 
		else 
		{
			jumping._FauxGravityAttractor = Planet02;
		}
	}
}
