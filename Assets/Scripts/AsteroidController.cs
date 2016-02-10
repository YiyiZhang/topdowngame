using UnityEngine;
using System.Collections;

public class AsteroidController : MonoBehaviour {

	public float speed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.position = this.transform.position - new Vector3 (Random.Range(0.01f,0.05f), Random.Range(-0.001f,0.009f), 0);
		this.transform.position = this.transform.position - new Vector3 (speed, Random.Range(-0.05f,0.05f), 0);
	}

}
