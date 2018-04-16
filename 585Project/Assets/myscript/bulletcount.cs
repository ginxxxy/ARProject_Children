using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bulletcount : MonoBehaviour {
	public static int bullet_count=10;
	public Text bullet;
	// Use this for initialization
	void Start () {
		bullet = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		bullet.text = "Bullet:" + bullet_count;
	}
}
