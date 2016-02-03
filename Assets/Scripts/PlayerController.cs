using UnityEngine;
using System.Collections;

/// <summary>
/// PlayerController takes in key inputs and moves the game object accordingly
/// </summary>

public class PlayerController : MonoBehaviour {

	public Rigidbody2D rbody;//rigidbodies control physics, if you make it public, it appears in inspector!!!
	float speed = 20f; //float is for decimals

	string upButton = "up"; //buttons are string variables
	string downButton = "down";
	string leftButton = "left";
	string rightButton = "right";
	
	// Update is called once per frame
	void Update(){		
		if (Input.GetKeyDown (upButton)) {
			rbody.AddForce (new Vector2 (0f, speed));
		}

		if (Input.GetKeyDown (downButton)) {
			rbody.AddForce (new Vector2 (0f, -speed));
		}

		if (Input.GetKeyDown (leftButton)) {
			rbody.AddForce (new Vector2 (-speed, 0f));
		}
			
		if (Input.GetKeyDown (rightButton)) {
			rbody.AddForce (new Vector2 (speed, 0f));
		}
	}

}