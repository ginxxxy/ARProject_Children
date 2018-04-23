using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public Text timerText;
	public float startTime;
	public bool gamePaused;
	Scene currentScene;
	string sceneName;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
		if (startTime != 0) {
			startTime = Time.time;
		}
		Debug.Log ("STATE of Pause: " + gamePaused);

		currentScene = SceneManager.GetActiveScene ();
		sceneName = currentScene.name;
	}

	// Update is called once per frame
	void Update () {
		float t = Time.time - startTime;
		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f0");
		timerText.text = minutes + ":" + seconds;

		if (sceneName == "mainMenu" || sceneName == "starRating") {
			gamePaused = true;
			Time.timeScale = 0f;
			Debug.Log ("PAUSED");
		} else {
			gamePaused = false;
			Time.timeScale = 1f;
			Debug.Log ("UNPAUSED");
		}
	}
}
