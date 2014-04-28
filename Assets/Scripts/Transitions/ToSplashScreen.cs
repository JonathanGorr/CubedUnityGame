using UnityEngine;
using System.Collections;

public class ToSplashScreen : MonoBehaviour {
	public float delayTime = 5;
	public bool done = false;

	private float timer;

	// Use this for initialization
	void Start () {
		timer = delayTime;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if(timer > 0) return;
		Application.LoadLevel (0);
	}
}
