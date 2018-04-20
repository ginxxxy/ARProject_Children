using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
	public GameObject ccoin;
	public int scorecount = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("s")){
			ccoin.SetActive (false);
			scorecount++;
		}
	}
}
