using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wandswitch : MonoBehaviour {
	public GameObject wand01;
	public GameObject wand02;
	public GameObject wand03;
	public GameObject wand04;
	// Use this for initialization
	void Start () {
		wand01.SetActive (true);
		wand02.SetActive (false);
		wand03.SetActive (false);
		wand04.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("1")){
			wand01.SetActive (true);
			wand02.SetActive (false);
			wand03.SetActive (false);
			wand04.SetActive (false);
		}
		if(Input.GetKeyDown("2")){
			wand01.SetActive (false);
			wand02.SetActive (true);
			wand03.SetActive (false);
			wand04.SetActive (false);
		}
		if(Input.GetKeyDown("3")){
			wand01.SetActive (false);
			wand02.SetActive (false);
			wand03.SetActive (true);
			wand04.SetActive (false);
		}
		if(Input.GetKeyDown("4")){
			wand01.SetActive (false);
			wand02.SetActive (false);
			wand03.SetActive (false);
			wand04.SetActive (true);
		}
	}
}
