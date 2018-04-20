using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectcoins : MonoBehaviour {
	public GameObject ccoin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("s")){
			Destroy(ccoin);
			Scorecount.scorevalue++;
		}
	}
	void OnMouseDown ()
	{
		Destroy(ccoin);
		Scorecount.scorevalue++;
	}
}
