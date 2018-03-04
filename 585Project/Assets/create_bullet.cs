using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_bullet : MonoBehaviour {
	public GameObject bullet;
	public GameObject cam;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void OnMouseDown () {
		Destroy (Instantiate (bullet, cam.transform.position,cam.transform.rotation), 5f);
	}
}
