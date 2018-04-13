using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour {

	int score = 0;


//	void onTriggerEnter(Collider other){
//		Debug.Log ("bbbbbbbbbb");
//		if (other.gameObject.tag == "fuck") {
//			//Destroy (Instantiate (col, transform.position, transform.rotation), 0.98f);
//			Debug.Log ("aaaaaaaaaaaaaaa");
//			Destroy (other.gameObject);
//			Destroy (gameObject);
//		//	cube.gameObject.GetComponent<Renderer> ().material.color = Color.red;
//
//		}
//	}	
	void Start () {
		
	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Cube")
		{
//			col.gameObject.GetComponent<Renderer> ().material.color = Color.red;
			col.gameObject.SetActive(false);
			score++;
		}
	}


}
