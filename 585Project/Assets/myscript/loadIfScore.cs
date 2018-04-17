using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadIfScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Scorecount.scorevalue > 0) {
			LoadLevel ("levelScene");
		}
	}

	public void LoadLevel(string scenename){
		Debug.Log("sceneName to load: " + scenename);
		SceneManager.LoadScene(scenename);
	}
}
