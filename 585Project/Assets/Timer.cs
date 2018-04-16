using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timerText;
	public float startTime;
	public bool gamePaused = true;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
		if (startTime != 0) {
			startTime = Time.time;
		}
		Debug.Log ("STATE of Pause: " + gamePaused);
	}
	
	// Update is called once per frame
	void Update () {
		float t = Time.time - startTime;
		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f0");
		timerText.text = minutes + ":" + seconds;
		if (!gamePaused) {
			t += Time.deltaTime;
		}
	}

	public void pauseGame(){
		gamePaused = true;
		Debug.Log ("PAUSED");
	}

	public void unpauseGame(){
		gamePaused = false;
		Debug.Log ("UNPAUSED");
	}
}
