using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour {

	public GameObject asteroid2spawn;
	public float spawnRateMin;
	public float spawnRateMax;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("AsteroidSpawn", 0.1f, Random.Range(spawnRateMin, spawnRateMax));
	}

	// Update is called once per frame
	void AsteroidSpawn () {

		Instantiate (asteroid2spawn);

	}
}
