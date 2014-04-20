using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {
	public float timer = 2f;
	public string levelToLoad = "Level1";

	// Use this for initialization
	void Start () {
		StartCoroutine ("SplashScreen");
	}

	IEnumerator LoadScreen() {
		yield return new WaitForSeconds(timer);
		Application.LoadLevel( levelToLoad );
	}
}
