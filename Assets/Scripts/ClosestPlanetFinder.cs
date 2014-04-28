using UnityEngine;
using System.Collections;

public class ClosestPlanetFinder : MonoBehaviour {

	public FauxGravityAttractor Planet01;
	public FauxGravityAttractor Planet02;
	public FauxGravityAttractor Planet03;
	public FauxGravityAttractor Planet04;
	public Jumping jumping;

	// Update is called once per frame
	void Update () {
		Vector3 distance01 = transform.position - Planet01.gameObject.transform.position;
		Vector3 distance02 = transform.position - Planet02.gameObject.transform.position;
		Vector3 distance03 = transform.position - Planet03.gameObject.transform.position;
		Vector3 distance04 = transform.position - Planet04.gameObject.transform.position;
	
	//if planet x is closer to player, attract thereto
	if (distance01.magnitude < distance02.magnitude) {
			jumping._FauxGravityAttractor = Planet01;
		}
	//else if planet 2 is closer to player than planet 1, attract to planet 2
	if (distance02.magnitude < distance01.magnitude) {
			jumping._FauxGravityAttractor = Planet02;
		} 
	if (distance03.magnitude < distance01.magnitude) {
			jumping._FauxGravityAttractor = Planet03;
		}
	if (distance04.magnitude < distance01.magnitude && distance04.magnitude < distance02.magnitude && distance04.magnitude < distance03.magnitude) {
			jumping._FauxGravityAttractor = Planet04;
		}
	}
}
