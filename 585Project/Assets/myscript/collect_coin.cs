using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_coin : MonoBehaviour {
	public GameObject coins;
<<<<<<< HEAD
=======
	public GameObject coins2;
	public GameObject coins3;
>>>>>>> ef4e1046809b88051eb830ae0b3b00c92d6af4f5
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void onClick(){
<<<<<<< HEAD
		Destroy (coins);
		Scorecount.scorevalue++;
=======
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
>>>>>>> ef4e1046809b88051eb830ae0b3b00c92d6af4f5
	}
}
