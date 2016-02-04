using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SpaceshipController : MonoBehaviour {

	public Rigidbody2D spaceshipbody;//rigidbodies control physics, if you make it public, it appears in inspector!!!

	string upButton = "up";
	string leftButton = "left";
	string rightButton = "right";
	string downButton = "down";

	float speed = 6f;

	// Use this for initialization
	void Start () {
		spaceshipbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (upButton)) {
			spaceshipbody.AddForce (transform.up * speed);
		}

		if (Input.GetKeyDown (leftButton)) {
			spaceshipbody.AddTorque (0.2f);
		}

		if (Input.GetKeyDown (rightButton)) {
			spaceshipbody.AddTorque (-0.2f);
		}

		if (Input.GetKeyDown (downButton)) {
			spaceshipbody.AddForce (-transform.up);
		}
	}

	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.tag == "Obstacle"){
			SceneManager.LoadScene(0);
		}
	}
}
