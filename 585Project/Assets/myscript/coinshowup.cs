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
<<<<<<< HEAD
			coin.SetActive (true);
=======
			if (coin != null) {
				coin.SetActive (true);
			}
>>>>>>> ef4e1046809b88051eb830ae0b3b00c92d6af4f5
		}
	}
}
