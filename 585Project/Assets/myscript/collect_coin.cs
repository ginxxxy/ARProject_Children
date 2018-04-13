using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_coin : MonoBehaviour {
	public GameObject coins;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void onClick(){
		Destroy (coins);
		Scorecount.scorevalue++;
	}
}
