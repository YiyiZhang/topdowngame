﻿using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	//public AudioClip needleSound; work on this


	// Use this for initialization
	void Start () {
	
		//needleSound = GetComponent<AudioSource> (); work on this
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D c){
		if (c.gameObject.tag == "Asteroid"){
			Destroy (c.gameObject);
			//sound effect event here!!
		}

}
}