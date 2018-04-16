using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinshowup : MonoBehaviour {
	public GameObject coin;
	public GameObject monster;
	// Use this for initialization
	void Start () {
		coin.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (monster.activeSelf == false) {
			if (coin != null) {
				coin.SetActive (true);
			}
		}
	}
}
