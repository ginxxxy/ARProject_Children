using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_coin : MonoBehaviour {
	public GameObject coins;
	public GameObject coins2;
	public GameObject coins3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void onClick(){
		if (coins.activeSelf == true) {
			Destroy (coins);
			Scorecount.scorevalue++;
		}
		if (coins2.activeSelf == true) {
			Destroy (coins2);
			Scorecount.scorevalue++;
		}
		if (coins3.activeSelf == true) {
			Destroy (coins3);
			Scorecount.scorevalue++;
		}
	}
}
