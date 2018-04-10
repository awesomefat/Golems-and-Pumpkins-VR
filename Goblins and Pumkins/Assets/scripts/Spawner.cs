using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public Transform[] spawnPoints;
    public GameObject pumpkin;

	// Use this for initialization
	void Start () 
    {
		StartCoroutine(startSpawning());
	}



    IEnumerator startSpawning()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3.5f));
        Instantiate(this.pumpkin, 
                    this.spawnPoints[Random.Range(0, this.spawnPoints.Length)].position, 
                    Quaternion.identity);
        StartCoroutine(startSpawning());
    }
}
