using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_bullet : MonoBehaviour {
	public GameObject bullet;
	public GameObject cam;
	public GameObject wand01;
	public GameObject wand02;
	public GameObject wand03;
	public GameObject wand04;
	public GameObject bullet01;
	public GameObject bullet02;
	public GameObject bullet03;
	public GameObject bullet04;
	// Use this for initialization
	void Start () {
//bullet01 = GameObject.Find ("orb01_purple");
	}
	
	// Update is called once per frame
	public void onClick () {
		if (wand01.activeSelf == true) {
			Destroy (Instantiate (bullet01, cam.transform.position, cam.transform.rotation), 5f);
		}
		if (wand02.activeSelf == true) {
			Destroy (Instantiate (bullet02, cam.transform.position, cam.transform.rotation), 5f);
		}
		if (wand03.activeSelf == true) {
			Destroy (Instantiate (bullet03, cam.transform.position, cam.transform.rotation), 5f);
		}
		if (wand04.activeSelf == true) {
			Destroy (Instantiate (bullet04, cam.transform.position, cam.transform.rotation), 5f);
		}
	}
}
                         