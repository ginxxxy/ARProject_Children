using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchWand : MonoBehaviour {

	public GameObject wand1;
	public GameObject wand2;
	public GameObject wand3;
	public GameObject wand4;
	private int index = 1;

	void Start(){
	}

	public void onClick(){
		if (index < 4) {
			index++;
		} else {
			index = 1;
		}
		if (index == 1) {
			wand1.SetActive (true);
			wand4.SetActive (false);
		}
		if (index == 2) {
			wand2.SetActive (true);
			wand1.SetActive (false);
		}
		if (index == 3) {
			wand3.SetActive (true);
			wand2.SetActive (false);
		}
		if (index == 4) {
			wand4.SetActive (true);
			wand3.SetActive (false);
		}

	}
}
