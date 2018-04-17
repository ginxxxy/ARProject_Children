using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}


	public void LoadLevel(string scenename){
		Debug.Log("sceneName to load: " + scenename);
		SceneManager.LoadScene(scenename);
	}
}
