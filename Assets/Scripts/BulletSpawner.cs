using UnityEngine;
using System.Collections;

/// <summary>
/// When player presses spacebar, bullets shoot out from the spaceship game object.
/// </summary>

public class BulletSpawner : MonoBehaviour {

	public GameObject bullet2spawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			//Instantiate only gives us back an object, NOT a game object
			Object o = Instantiate (bullet2spawn, this.transform.position, Quaternion.identity); //this.transform.position is the variable that holds the position of the ship
			GameObject bulletbaby = (GameObject)o; //bulletbaby object needs to be typecasted as a Game Object to function!!!
			//GameObject bulletbaby = o as GameObject; //another way to cast
			//GameObject bulletbaby = (GameObject)Instantiate (bullet2spawn, this.transform.position, Quaternion.identity); //another way to cast
			Rigidbody2D fullgrownbullet = bulletbaby.GetComponent<Rigidbody2D>();//can't directly add force to bulletbaby because it is a prefab!
			fullgrownbullet.AddForce (this.transform.up * 20); //transform.up is already a vector so it doesn't need to be set as a vector
		}
	
	}
}
