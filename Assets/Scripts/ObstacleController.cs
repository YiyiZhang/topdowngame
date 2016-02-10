using UnityEngine;
using System.Collections;

public class ObstacleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D c){
		if (c.gameObject.tag == "Asteroid"){
			AsteroidController asCont = c.gameObject.GetComponent<AsteroidController>();
			asCont.speed = -asCont.speed;
			print ("Changed Speed" + asCont.speed);
		}
	}
}
